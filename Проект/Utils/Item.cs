using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage2.Utils
{
    //объект, реализующий этот интерфейс
    //должен поддерживать функцию
    //конвертации строки из БД в свое состояние
    public interface IParse
    { Item Parse(params object[] row); }
    

    //базовый класс для всех сущностей в БД
    public abstract class Item : ICloneable
    {
        //id в таблице БД
        public int id { get; protected set; }

        //строка, предсталвяющая объект, для записи в БД
        public abstract object[] row { get; }

        //создание копии объекта на основе его данных
        public abstract object Clone();

        //Установление id, может быть изменено в производных классах
        public virtual void SetID(int value) { id = value; }

        //Сообщение об ошибке при получении null значения
        public readonly static Exception NotFound
            = new NullReferenceException("Строка не выбрана");

    }
}
