using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Storage2.Utils
{
    public static class DBFabric
    {

        internal class DBConnection
        {

            //информация о соединении в экземпляре класса
            private MySqlConnection connection;
            private const string q = "DBConnection:  ";

            //конструктор класса
            internal DBConnection(string cnt)
            { connection = new MySqlConnection(cnt); }

            //создаем экземлпяр с проверкой соединения


            internal DataTable Select(string sql)
            {
                //объявляем результат
                var result = new DataTable();
                try
                {
                    //создаем команду, передав запрос и соединение
                    var cmd = new MySqlCommand(sql, connection);
                    connection.Open(); //открываем соединение
                    result.Load(cmd.ExecuteReader()); //читаем запрос в результат
                }
                //выводим исключение если что-то пошло не так
                catch (Exception ex) { Program.Log(ex, q); }
                connection.Close(); //закрываем соединение
                return result; //возвращаем результат
            }

            internal Boolean Execute(string sql)
            {
                //тоже самое, однако запрос выполняется
                //без чтения, в случае успеха выдаст true,
                //если словил ошибку -- печатает его в консоль и выдает false
                try
                {
                    var cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine($"{q}{ex.Message}");
                    return false;
                }
            }
            //ищет данные из sql-запроса по ключевому слову request в стоблце column
            internal DataTable Search(string sql, string request, int column)
            {
                //получаем результат запроса
                DataTable table = Select(sql);
                //формируем таблицу по каркасу результата запроса
                DataTable view = table.Copy(); view.Clear();
                //заполняем данными с учетом поискового слова
                foreach (DataRow R in table.Rows)
                {
                    if (R.ItemArray[column].ToString().Contains(request))
                    { view.Rows.Add(R.ItemArray); }
                }
                //возвращаем результат
                return view;
            }
        }


        //экземпляр класса для работы с базой данных mysql
        private static DBConnection engine;
        
        //с проверкой на инициализацию
        private static DBConnection Engine
        {
            get
            {
                if (engine == null)
                {
                    string message = Properties.Resources.NoMadeConnection;
                    throw new Exception(message);
                }
                else { return engine; }
            }
            set
            { engine = value; }
        }

        //создаем экземлпяр с проверкой соединения
        public static bool Init(MySqlConnectionStringBuilder builder, string SqlTest)
        {
            try
            {
                Engine = new DBConnection(builder.ToString());
                return Engine.Execute(SqlTest);
            }
            catch (Exception ex) { Program.Log(ex); return false; }
        }

        //осуществить запрос бд с возвратом результата
        public static DataTable Select(string sql)
        { return Engine.Select(sql); }
        
        //осуществить запрос к бд с возвратом статуса его выполнения
        public static Boolean Execute(string sql)
        { return Engine.Execute(sql); }
        
        //найти в выдаче запроса конкретную информацию
        public static DataTable Search(string sql, string request, int column)
        { return Engine.Search(sql, request, column); }
    }
}
