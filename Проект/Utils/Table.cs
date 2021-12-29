using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Storage2.Utils
{
    //описывает таблицу БД указанного типа сущностей
    //где T -- класс сущности, производный от Item
    public class Table<T>
    {
        //сообщение об ошибке
        protected static readonly Exception NotFound
            = new Exception("объект не найден");


        //хранилище локальной копии записей БД
        protected List<Item> items;

        //хранилище полей(колонок) БД
        protected Field[] fields;


        //возвращет информацию о месте, в котором возникла ошибка
        protected string from => $"Table|{name}:  "; 


        public string name { get; protected set; }


        //получает полную копию таблицы БД в неформатированном виде
        public virtual DataTable DataSource => SQL($"SELECT * FROM `{name}`");


        //конструктор таблицы
        public Table(string name, IParse RowReader, params Field[] fields)
        {
            this.fields = fields;
            items = new List<Item>();
            this.name = name;
            CreateInstance(RowReader);
        }

        //Производит обработку внутренних Sql-Запросов
        protected virtual DataTable SQL(string sql) => DBFabric.Select(sql);


        //возвращет элемент из хранилища по указанному индексу
        public T this[int index] => (T)items[index].Clone();


        protected virtual void CreateInstance(IParse RowReader)
        {
            try
            {
                //набираем sql-запрос на основании полей таблицы
                var sql = new StringBuilder($"CREATE TABLE `{name}` ( `id` INT(8) NOT NULL AUTO_INCREMENT ,");
                foreach (var f in fields)
                { sql.Append($" `{f.Name}` {f.Type} NOT NULL ,"); }
                sql.Append($" PRIMARY KEY (`id`)) ENGINE = INNODB");

                //пытаемся создать таблицу
                if (!DBFabric.Execute(sql.ToRequest()))
                {
                    //если таблица уже существует, то заполняем
                    //хранилище данными из нее
                    foreach (DataRow row in DataSource.Rows)
                    { items.Add(RowReader.Parse(row.ItemArray)); }
                    items.OrderBy(x => x.id);
                }
            }
            catch (Exception ex) { Program.Log(ex, from); }
        }


        protected int FindIndex(Item item)
        {
            //поиск индекса элемента в хранилище
            //на основании его id бд
            //в результате чего не зависит
            //от низкоуровневого состояния объекта
            for (int i = 0; i < items.Count; i++)
            { if (items[i].id == item.id) { return i; } }
            throw NotFound;
        }

        //добавление записи в таблицу и БД
        public int Append(Item item)
        {
            try
            {
                //формируем строки запроса, отвечающе за
                //поля, в которые мы хотим вставить данные
                var sql = new StringBuilder($"INSERT INTO `{name}` (`id`, ");
                int i = 0;
                while (i < fields.Length - 1)
                { sql.Append($"`{fields[i].Name}`, "); i++; }
                sql.Append($"`{fields[i].Name}`)VALUES(NULL, "); i = 1;


                //формируем строки запроса, отвечающее
                //за само размещение данных
                object[] row = item.row;
                while (i < row.Length - 1)
                { sql.Append($"'{row[i]}', "); i++; }
                sql.Append($"'{row[i]}');");




                //пытаемся выполнить запрос
                if (DBFabric.Execute(sql.ToRequest()))
                {
                    //получаем обновленную копию состояния БД
                    var table = DataSource;
                    int q = table.Rows.Count;
                    int[] ids = new int[q];
                    for (int j = 0; j < q; j++)
                    { ids[j] = table.Rows[j].ItemArray[0].ToInt32(); }
                    Array.Sort(ids); Array.Reverse(ids);
                    //узнаем id добавленного элемента
                    int id = ids[0];
                    //задаем id объеткту и добавляем его в хранилище
                    item.SetID(id); items.Add(item); return id;
                }
                //Иначе выводим предполагаемую ошибку пользователя
                else { throw new Exception(Properties.Resources.NotUnique); }
            }
            catch(Exception ex) { Program.Log(ex, from); return -1; }
        }

        //обновление элемента в таблце и БД
        public void Update(Item item)
        {
            try
            {
                //заменяем нужный элемент в хранидище
                items[FindIndex(item)] = item;

                //получаем строку элемента и объявляем строку запроса
                object[] row = item.row; int i = 0;
                var sql = new StringBuilder($"UPDATE `{name}` SET ");

                //формируем сам запрос
                while (i < fields.Length - 1)
                { sql.Append($"`{fields[i].Name}` = '{row[i + 1]}', "); i++; }
                sql.Append($"`{fields[i].Name}` = '{row[i + 1]}' WHERE `{name}`.`id` = {item.id};");

                //и выполняем его
                SQL(sql.ToRequest());
            }
            catch (Exception ex) { Program.Log(ex, from); }
        }


        //удаляет элемент из хранилища и БД
        public void Delete(Item item)
        {
            try
            {
                if (item != null)
                { SQL($"DELETE FROM `{name}` WHERE `{name}`.`id` = {item.id}"); }
                else
                { Program.Log(Item.NotFound); }
                items.Remove(item);
            }
            catch (Exception ex) { Program.Log(ex, from); }
        }


        //осуществляет поиск элемента по его id в БД
        public T Search(int id)
        {
            foreach (var i in items)
            { if (i.id == id) { return (T)(object)i; } }
            throw NotFound;
        }


        //осуществляет поиск элемент по запросу в укзанной колонке
        public List<T> Search(string request, int column)
        {
            var result = new List<T>();
            request = request.ToLower();
            foreach (var i in items)
            {
                //если запись элемента в укзаной колонке
                //содержит поисковое слово
                //то добавляем его в выдачу результата
                if (Convert.ToString(i.row[column]).ToLower().Contains(request))
                { result.Add((T)(object)i); }
            }
            return result;
        }

        //возвращает все элементы из хранилиза
        //приводя их к типу сущности таблицы
        public List<T> GetAll() =>
            items.Select(x => (T)(object)x).ToList<T>(); 

    }
}
