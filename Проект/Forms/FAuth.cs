using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Storage2.Utils;

namespace Storage2.Forms
{
    public partial class FAuth : Form
    {
        public FAuth()
        {
            InitializeComponent();
        }

        //сообщение о неправильных параметрах подключения
        private readonly static Exception Error =
            new Exception(Properties.Resources.InvalidConnection);

        private void BTN_Init_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string cnt = TB_ConnectionString.Text;
            //если строка подклчения не пустая
            if (cnt != "")
            {
                //то набираем параметры подключения из нее
                try
                {
                    //парсим строку подключения
                    string[] items = cnt.Split(';').Select(x => x.Split('=')[1]).ToArray();
                    //заполняем текстбоксы
                    TB_IP.Text = items[0];
                    TB_Port.Text = items[1];
                    TB_Login.Text = items[2];
                    TB_Password.Text = items[3];
                    TB_DataBase.Text = items[4];
                }
                catch (Exception ex)
                {
                    //в случае ошибки выводим ее в консоль
                    Console.WriteLine(ex.Message);
                    //дальнейшая авторизация невозможна
                    valid = false;
                }
            }
            //если парамтры подключения синтаксически правильны
            if (valid && UInt16.TryParse(TB_Port.Text, out ushort port))
            {
                //создаем билдер строки подключения
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = TB_IP.Text,
                    Port = port,
                    UserID = TB_Login.Text,
                    Password = TB_Password.Text,
                    Database = TB_DataBase.Text,
                    CharacterSet = "utf8"
                };
                //приводим его к строке
                cnt = builder.ToString();
                //копируем строку в буфер обмена и текстбокс
                Clipboard.SetText(cnt);
                TB_ConnectionString.Text = cnt;

                //если удалось установить соединение с готовой БД
                if (DBFabric.Init(builder, "SELECT * FROM `product_info`"))
                    //то открываем форму выбора таблиц
                { new FForms().Show(); }
                
                //если БД пустая и отмечено ее создание
                else if (checkBox1.Checked)
                {
                    //пытаемся ее создать при помощи sql-скрипта из ресурсов программы
                    if (DBFabric.Execute(Properties.Resources.SqlRestore))
                        //если все успешно, то открываем форму выбора таблиц
                    { Program.Log("База данных создана"); new FForms().Show(); }
                    //иначе сообщаем об ошибке
                    else
                    {
                        Program.Log(new Exception("Ошибка при создании бд\n" +
                          "Смотрите консоль для более подробной информации"));
                    }
                }
                
                else
                { Program.Log(Error); }
            }
            else { Program.Log(Error); }
            
            //высвобождаем неиспользуемые ресурсы
            Program.Clear();
        }

        //очищаем все поля
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_IP.Text = "";
            TB_Port.Text = "";
            TB_Login.Text = "";
            TB_Password.Text = "";
            TB_DataBase.Text = "";
            TB_ConnectionString.Text = "";
            //высвобождаем неиспользуемые ресурсы
            Program.Clear();
        }
    }
}
