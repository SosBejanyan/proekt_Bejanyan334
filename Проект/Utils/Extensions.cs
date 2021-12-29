using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage2.Utils
{
    //методы расширения, обеспечивающие преобразования типов
    //без вызова класса Convert и выдачи исключений.
    //возвращают значение если преобразование удалось, иначе 0
    //(вызываются от переменных типов, обозначенных вместе с this)
    public static class Extensions
    {
        public static int ToInt32(this string value) =>
            Int32.TryParse(value, out int result) ? result : 0;

        public static long ToInt64(this string value) =>
            Int64.TryParse(value, out long result) ? result : 0;

        public static int ToInt32(this object value) =>
            Convert.ToString(value).ToInt32();

        public static long ToInt64(this object value) =>
            Convert.ToString(value).ToInt64();


        public static decimal ToDecimal(this object value) =>
            Decimal.TryParse
            (
                Convert.ToString(value).Replace('.', ','),
                out decimal result
            )
            ? result : Decimal.Zero;


        //приводит запрос к строке
        //и печатает его в консоль
        //из любого места программы
        public static string ToRequest(this StringBuilder sql)
        {
            string request = sql.ToString();
            Console.WriteLine(request);
            return request;
        }

        //возвращает одно из пары значений в зависимости от результата
        //например false.ToString("Покупатель", "Поставщик") == "Покупатель"
        //в случае ошибки возвращает "Нет" и "Да" соответственно
        public static string ToString(this bool value, params string[] values) =>
            values.Length >= 2 ? values[Convert.ToInt32(value)] : MySqlConvert.ToString(value);

        //проверяет, принадлежит ли значение указанному диапазону
        public static bool InRange(this decimal value, decimal first, decimal end) =>
            value >= first && value <= end;
    }
}
