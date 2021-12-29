using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage2.Utils;
using Storage2.Entities;

namespace Storage2.Forms
{
    public partial class FClient : Form
    {
        public FClient()
        {
            InitializeComponent();
            Review();
            domainUpDown1.SelectedIndex = 0;
        }

        //объект, с которым сейчас работает пользователь
        private Client CurrentItem;

        //кэш поискового запроса
        private object[] search = new object[2] { "", 0 };

        //при нажатии на строку
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            //достаем элемент из тэга
            CurrentItem = dataGridView1.SelectedRows[0].Tag as Client;
            //заполняем по нему все поля
            TB_Name.Text = CurrentItem.name;
            TB_FIO.Text = CurrentItem.owner_fio;
            TB_Address.Text = CurrentItem.address;
            TB_PostIndex.Text = CurrentItem.post_index.ToString();
            TB_Phone.Text = CurrentItem.phone.ToString();
            TB_Email.Text = CurrentItem.email;
            TB_Notes.Text = CurrentItem.notes;
            radioButton1.Checked = CurrentItem.BuyerSaler;
            radioButton2.Checked = !radioButton1.Checked;
        }

        //обновление данных
        private void Review(string search = "", int column = 1)
        {
            //очищаем поля таблицы
            dataGridView1.Rows.Clear();

            //перебираем элементы, отвечающие поисковому запросу
            foreach (var item in Tables.clients.Search(search, column))
            {
                //форматируем данные
                object[] row = item.row;
                row[2] = MySqlConvert.ToInitials(row[2]);
                row[7] = item.BuyerSaler.ToString("Покупатель", "Поставщик");
                
                //тип проссматриваемых клиентов
                int viewtype = domainUpDown1.SelectedIndex;

                //если совпадает, то добавляем объект в таблицу
                if (viewtype == 0 || item.row[7].ToInt32() == 2 - viewtype)
                {
                    int index = dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[index].Tag = item;
                }
            }
            //очищаем память и кэшируем поисковой запрос
            Program.Clear(); this.search = new object[2] { search, column };
        }

        private void SearchType(object sender, EventArgs e)
        { Review(search[0].ToString(), search[1].ToInt32()); }

        private void SearchName(object sender, EventArgs e)
        { Review(TB_Search_Name.Text, 1); }

        private void SearchFIO(object sender, EventArgs e)
        { Review(TB_Search_FIO.Text, 2); }

        private void SearchNotes(object sender, EventArgs e)
        { Review(TB_Search_Notes.Text, 8); }

        private void SearchAddress(object sender, EventArgs e)
        { Review(TB_Search_Address.Text, 3); }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект на основе введенных данных
                var item = new Client
                (
                    MySqlConvert.ToNotNull(TB_Name.Text),
                    MySqlConvert.ToNotNull(TB_FIO.Text),
                    MySqlConvert.ToNotNull(TB_Address.Text),
                    MySqlConvert.ToNotNull(TB_PostIndex.Text).ToInt32(),
                    MySqlConvert.ToNotNull(TB_Phone.Text).ToInt64(),
                    TB_Email.Text,
                    radioButton1.Checked,
                    TB_Notes.Text
                );
                //добавляем в таблицу и обновляем данные
                Tables.clients.Append(item);
                Review();
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        //заполненяем объект новыми данными и обновляем его в таблице
        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentItem == null)
                { Program.Log(Item.NotFound); }
                else
                {
                    CurrentItem.name = MySqlConvert.ToNotNull(TB_Name.Text);
                    CurrentItem.owner_fio = MySqlConvert.ToNotNull(TB_FIO.Text);
                    CurrentItem.address = MySqlConvert.ToNotNull(TB_Address.Text);
                    CurrentItem.post_index = MySqlConvert.ToNotNull(TB_PostIndex.Text).ToInt32();
                    CurrentItem.phone = MySqlConvert.ToNotNull(TB_Phone.Text).ToInt64();
                    CurrentItem.email = TB_Email.Text;
                    CurrentItem.BuyerSaler = radioButton1.Checked;
                    CurrentItem.notes = TB_Notes.Text;
                    Tables.clients.Update(CurrentItem);
                    Review();
                }
            }
            catch(Exception ex) 
            { Program.Log(ex); }

        }

        //если строка выбрана, то удаляем объект, который она представляет
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            { 
                Tables.clients.Delete(CurrentItem);
                Review();
            }
        }

        //если строка выбрана, то копируем объект, который она представляет
        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else { Program.Copy(CurrentItem.row); }
        }

        //осищаем поля ввода данных
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_Search_FIO.Text = "";
            TB_Search_Name.Text = "";
            TB_Search_Notes.Text = "";
            Review();
        }

        //заглушка
        private void FClient_Load(object sender, EventArgs e)
        { Console.WriteLine("1"); }
    }
}
