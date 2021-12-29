using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage2.Utils
{
    //класс для осуществления преобразований
    //типов, совместимых с СУБД MySql
    public static class MySqlConvert
    {
        public static string ToString(decimal value) =>
            Convert.ToString(value).Replace(',', '.');

        public static string ToString(bool value) =>
            value ? "Да" : "Нет";

        public static string ToBit(bool value) =>
            value ? "1" : "";

        public static string ToNotNull(string value) =>
            value != "" ? value : throw new Exception(Properties.Resources.NullField);

        public static string[] ToString(object[] values) =>
            values.Select(x => x.ToString()).ToArray();


        public static int ToID(object item) => 
            (item as Item).id;

        public static string ToInitials(object value)
        {
            try
            {
                string[] fio = Convert.ToString(value).Split(' ');
                return $"{fio[1][0]}. {fio[2][0]}. {fio[0]}";
            }
            catch { return "John Doe"; }
        }

        public static string ToString(DateTime date) =>
            $"{date.Year}-{date.Month}-{date.Day}";
    }
}
