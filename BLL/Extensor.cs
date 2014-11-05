using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public static class Extensor {
        public static string ToDbString(this DateTime dt) {
            return "'" + dt.ToTextFieldString() + "'";
        }
        public static string ToTextFieldString(this DateTime dt) {
            return dt.ToString("yyyy-MM-dd");
        }
        public static DateTime ToDate(this string str) {
            return DateTime.Parse(str);
        }

        public static string ToDbString(this string str) {
            return "'" + str + "'";
        }

        public static string ToDbString(this bool boolean) {
            return "'" + boolean + "'";
        }
    }
}
