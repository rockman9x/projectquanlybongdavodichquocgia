using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class DataUtils
    {
        public static long ToLong(object ob, long defaultValue)
        {
            try
            {
                return long.Parse(ob.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static long ToLong(object ob)
        {
            return ToLong(ob, 0);
        }

        /// <summary>
        /// Convert an object to integer number. If error occured,
        /// return to defaultValue.
        /// </summary>
        /// <param name="ob"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ToInt(object ob, int defaultValue)
        {
            try
            {
                return int.Parse(ob.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Convert an object to integer number.
        /// If error occured, return 0.
        /// </summary>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static int ToInt(object ob)
        {
            return ToInt(ob, 0);
        }

        public static float ToFloat(object ob, float defaultValue)
        {
            try
            {
                return float.Parse(ob.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static float ToFloat(object ob)
        {
            return ToFloat(ob, 0);
        }

        /// <summary>
        /// Convert an object to decimal number. If error occured,
        /// return to defaultValue.
        /// </summary>
        /// <param name="ob"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ToDouble(object ob, double defaultValue)
        {
            try
            {
                return double.Parse(ob.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Convert an object to decimal number.
        /// If error occured, return 0.
        /// </summary>
        /// <param name="ob"></param>
        /// <returns></returns>
        public static double ToDouble(object ob)
        {
            return ToDouble(ob, 0);
        }

        public static bool ToBoolean(object ob, bool defaultValue)
        {
            try
            {
                return bool.Parse(ob.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static bool ToBoolean(object ob)
        {
            return ToBoolean(ob, false);
        }

        public static string ToString(object ob)
        {
            return ob.ToString();
        }

        public static DateTime ToDateTime(object ob)
        {
            try
            {
                return DateTime.Parse(ob.ToString());
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        public static bool KiemTra(params string[] s)
        {
            foreach(string t in s)
                if (t.Length == 0)
                {
                    return false;
                }
            return true;
        }
    }
}
