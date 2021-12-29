using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage2.Entities;
using Storage2.Utils;

namespace Storage2.Forms
{
    public partial class FProductInfo : Form
    {
        public FProductInfo()
        {
            InitializeComponent();
            Review();
            domainUpDown1.SelectedIndex = 0;
        }

        //текущий объет, с которым работает пользователь
        private ProductInfo CurrentItem;

        //обновляем данные в соответствии с поисковым запросом
        private void Review(string search = "", int column = 1)
        {
            //очищаем поля в таблице
            dataGridView1.Rows.Clear();
            //перебираем элементы в таблице, отвечающие поисковому запросу
            foreach(var item in Tables.product_info.Search(search, column))
            {
                //форматируем строку объекта и вкидываем ее в таблицу
                object[] row = item.row;
                row[1] = item.product_type.type;
                int index = dataGridView1.Rows.Add(row);
                //вкидываем в тэг строки сам объект
                dataGridView1.Rows[index].Tag = item;
            }
            //очищаем элементы выпадающего списка
            domainUpDown1.Items.Clear();
            //перебираем элементы соответствующего типа
            //и вкидываем в список
            foreach(var item in Tables.product_type.GetAll())
            { domainUpDown1.Items.Add(item); }
            //чистим память
            Program.Clear();
        }

        //поиск по типу
        //тоже самое, как и выше
        private void SearchType(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string search = TB_Search_Type.Text;
            foreach (var item in Tables.product_info.GetAll())
            {
                string type = item.product_type.type;
                //однако теперь проверяем на соответствие запросу вторичный ключ
                if (type.Contains(search))
                {
                    object[] row = item.row;
                    row[1] = type;
                    int index = dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[index].Tag = item;
                }
            }
            Program.Clear();
        }

        private void SearchName(object sender, EventArgs e)
        { Review(TB_Search_Name.Text, 2); }

        private void SearchBrand(object sender, EventArgs e)
        { Review(TB_Search_Brand.Text, 3); }

        private void SearchDescription(object sender, EventArgs e)
        { Review(TB_Search_Description.Text, 4); }

        //при нажатии на строку достаем из нее объект и заполняем поля его данными
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            CurrentItem = dataGridView1.SelectedRows[0].Tag as ProductInfo;
            string[] row = CurrentItem.row.Select(x => x.ToString()).ToArray();
            row[1] = CurrentItem.product_type.type;
            domainUpDown1.SelectedIndex = domainUpDown1.Items.IndexOf(CurrentItem.product_type);
            TB_Name.Text = row[2];
            TB_Brand.Text = row[3];
            TB_Decription.Text = row[4];
            TB_Cost.Text = row[5];
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //формируем строку объекта
                //пригодную для sql запроса
                object[] row = new object[6]
                {
                new Random().Next(Int32.MaxValue),
                MySqlConvert.ToID(domainUpDown1.SelectedItem),
                MySqlConvert.ToNotNull(TB_Name.Text),
                MySqlConvert.ToNotNull(TB_Brand.Text),
                TB_Decription.Text,
                TB_Cost.Text
                };
                //вкидываем новый объект в таблицу на основании строки
                Tables.product_info.Append(new ProductInfo().Parse(row));

                //обновляем данные
                Review();
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentItem == null)
                { Program.Log(Item.NotFound); }
                else
                {
                    //заполняем объект введенными данными и обновляем его в таблице
                    CurrentItem.product_type = domainUpDown1.SelectedItem as ProductType;
                    CurrentItem.name = TB_Name.Text;
                    CurrentItem.brand = TB_Brand.Text;
                    CurrentItem.description = TB_Decription.Text;
                    CurrentItem.cost = TB_Cost.Text.ToDecimal();
                    Tables.product_info.Update(CurrentItem);
                    Review();
                }
            }
            catch { Program.Log(Item.NotFound); }
        }

        //если строка выбрана, то удаляем объект
        //иначе сообщаем об ошибке
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                Tables.product_info.Delete(CurrentItem);
                Review();
            }
        }

        //если строка выбрана, то копируем обхект в буфер обмена
        //иначе сообщаем об ошибке
        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else { Program.Copy(CurrentItem.row); }
        }

        //очищаем все поля поиска и обновляем данные
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_Search_Type.Text = "";
            TB_Search_Name.Text = "";
            TB_Search_Brand.Text = "";
            TB_Search_Description.Text = "";
            Review();
        }
    }
}
