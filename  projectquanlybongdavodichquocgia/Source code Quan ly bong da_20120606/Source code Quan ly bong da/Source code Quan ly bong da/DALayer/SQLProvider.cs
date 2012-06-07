using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace DALayer
{
    public class SQLProvider
    {
        /// <summary>
        /// Execute_NonQuery() sử dụng trong các câu lệnh select và update
        /// Kiểu trả về là Interger(các hằng số bị ảnh hưởng)
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static bool Execute_NonQuery(string strSQL)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd = new SqlCommand(strSQL, conn);
            try
            {
                conn.Open();
                if (comd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else 
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


        public static bool Execute_NonQuery(string SQLstore, params SqlParameter[] paras)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd = new SqlCommand(SQLstore, conn);

            try
            {
                conn.Open();
                //SqlCommand comd = new SqlCommand(SQLstore, conn);
                comd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                    comd.Parameters.AddRange(paras);
                if (comd.ExecuteNonQuery() > 0)
                {                    
                    return true;
                }
                else 
                return false;
            }
            catch 
            {
                return false;
            }
            finally
            {
                conn.Close(); conn.Dispose();
            }
           
        }

        /// <summary>
        /// Execute_Scalar() sử dụng trong các câu lệnh insert và select
        /// Kiểu trả về là Systems.Object( một giá trị dữ liệu).
        /// </summary>
        /// <param name="SQLstore"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object Execute_Scalar(string SQLstore, params SqlParameter[] paras)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd = new SqlCommand(SQLstore, conn);
            comd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                if (paras != null)
                    comd.Parameters.AddRange(paras);
                return comd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close(); conn.Dispose();
            }
        }

        public static object Execute_Scalar(string strSQL)
        {
            SqlConnection objConn = ConnectToDataBase.StartConnection();
            SqlCommand objCmd = new SqlCommand(strSQL, objConn);
            try
            {
                if (objCmd.Connection.State != ConnectionState.Open)
                {
                    objConn.Open();
                }
                return objCmd.ExecuteScalar();
            }
            catch
            {

                return null;
            }
            finally
            {
                objCmd.Connection.Close();
                objCmd.Dispose();
            }
        }


        /// <summary>
        /// Sử dụng khi cần tạo và di chuyển 1 đối tượng DataReader
        /// </summary>
        /// <param name="SQLstr"></param>
        /// <returns></returns>
        public static SqlDataReader Execute_Reader(string SQLstr)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd = new SqlCommand(SQLstr, conn);
            SqlDataReader dr;
            try
            {
                conn.Open();
                dr = comd.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }
        }


        public static SqlDataReader Execute_Reader(string storename, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd = new SqlCommand(storename, conn);
            comd.CommandType = CommandType.StoredProcedure;
            if (comd.Connection.State == ConnectionState.Closed)
            {
                comd.Connection.Open();
            }

            if (sqlParams != null)
            {
                for (int i = 0; i < sqlParams.Length; i++)
                {
                    comd.Parameters.Add(sqlParams[i]);
                }
            }

            try
            {
                return comd.ExecuteReader();
            }
            catch
            {

                return null;
            }
        }

        /// <summary>
        /// Mỗi đối tượng DataSet có thể chứa đựng 1 hay nhiều đối tượng lớp DataTable
        /// DataTable: DataView, DataColumn, UniqueConstraint, ForegionnKeyConstraint
        /// </summary>
        /// <param name="SQLstr"></param>
        /// <returns></returns>
        public static DataTable Fill_Table(string SQLstr)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlDataAdapter da = new SqlDataAdapter(SQLstr, conn);
            
            //SqlCommand sqlcmd = new SqlCommand(SQLstr, conn);
            //sqlcmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            try
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                da.SelectCommand.Connection.Close();
                da.SelectCommand.Dispose();
                da.Dispose();
            }
        }


        public static DataTable Fill_Table(string storeName, params SqlParameter[] paras)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlDataAdapter da = new SqlDataAdapter(storeName, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                if (paras != null)
                    da.SelectCommand.Parameters.AddRange(paras);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                da.SelectCommand.Connection.Close();
                da.SelectCommand.Dispose();
                da.Dispose();
            }
        }

        public static DataTable BiExecute_Table(string strSQL)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            try
            {
                conn.Open();
                SqlCommand comd = new SqlCommand(strSQL, conn);
                DataTable table = new DataTable();
                table.Load(comd.ExecuteReader());
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public static object GetValue(string strTable, string strKey, object keyValue, string strColumn)
        {
            string strSQL;
            strSQL = "Select " + strColumn + " From " + strTable + " Where " + strKey + " = " + keyValue;
            SqlConnection conn = ConnectToDataBase.StartConnection();
            return Execute_Scalar(strSQL);
        }

        public static object GetValue(string strTable, string strKey, object keyValue, string strColumn, string strCond)
        {
            string strSQL;
            strSQL = "Select " + strColumn + " From " + strTable + " Where " + strKey + " = " + keyValue + " AND " + strCond;
            SqlConnection conn = ConnectToDataBase.StartConnection();
            return Execute_Scalar(strSQL);
        }

        public static bool HasRecord(string strTable, string strKey, object keyValue, string Condition)
        {
            string strSQL = "Select count(" + strKey + ") From " + strTable + " Where " + strKey + " = " + keyValue;
            if (Condition != "")
            {
                strSQL += " And " + Condition;
            }
            int intResult;
            intResult = DataUtils.ToInt(Execute_Scalar(strSQL));
            if (intResult != 0)
                return true;
            else
                return false;
        }

        public static int Count(string strTable, string strKey, string strCond)
        {
            string strSQL = "SELECT COUNT(" + strKey + ") As ICount FROM " + strTable;
            if (strCond != null)
                strSQL += " WHERE " + strCond;

            int intResult;
            intResult = DataUtils.ToInt(Execute_Scalar(strSQL));
            return intResult;
        }

        public static int Count(string strSQL)
        {
            int intResult;
            intResult = DataUtils.ToInt(Execute_Scalar(strSQL));
            return intResult;
        }
        public static string GetAll(string str)
        {
            string s = "select * from " + str;
            return s;
        }

        public static DataTable Store_Execute_Table(string storeSQL)
        {
            SqlConnection conn = ConnectToDataBase.StartConnection();
            SqlCommand comd =new SqlCommand(storeSQL,conn);
            try
            {
                conn.Open();
                comd.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                table.Load(comd.ExecuteReader());
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();

            }

        }
    }
}
