using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage2.Utils
{
    public enum EMySqlType //перечисление типов данных в среде MySql
    { INT32, INT64, VARCHAR, DECIMAL, DOUBLE, DATE, TEXT, BOOLEAN }

    //описывает колонку таблицы БД
    public struct Field
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public Field(string name, EMySqlType type)
        {
            Name = name;
            //инициализация посредством enum
            //позволяет обезопасить задание типа
            //от введения пользователем
            //недопустимых значений 
            switch (type) 
            {
                case EMySqlType.INT32:
                    Type = "INT(8)"; break;
                case EMySqlType.INT64:
                    Type = "BIGINT(16)"; break;
                case EMySqlType.VARCHAR:
                    Type = "VARCHAR(64)"; break;
                case EMySqlType.DECIMAL:
                    Type = "DECIMAL(18,2)"; break;
                case EMySqlType.DOUBLE:
                    Type = "DOUBLE(8,8)"; break;
                case EMySqlType.DATE:
                    Type = "DATE"; break;
                case EMySqlType.TEXT:
                    Type = "TEXT"; break;
                case EMySqlType.BOOLEAN:
                    Type = "BIT(1)"; break;
                default:
                    Type = "VARCHAR(64)"; break;
            }
        }
    }
}
