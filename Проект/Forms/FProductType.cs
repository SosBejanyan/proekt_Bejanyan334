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
    public partial class FProductType : Form
    {
        public FProductType()
        {
            InitializeComponent();
            Review();
        }

        //текущий объект, с которым работает пользователь
        private ProductType CurrentItem;

        //обновление данных на основе поискового запроса
        private void Review(string search="")
        {
            //чистим строки dgv
            dataGridView1.Rows.Clear();
            //перебираем все элементы, отвечающие запросу
            foreach (var item in Tables.product_type.Search(search, 1))
            {
                //вкидываем в таблицу строку элемента
                int index = dataGridView1.Rows.Add(item.row);
                //вкидываем сам элемент в тэг добавленной строки
                dataGridView1.Rows[index].Tag = item;
            }
            //чистим память
            Program.Clear();
        }

        //производим поиск при обновлении текстбокса
        private void Search(object sender, EventArgs e)
        { Review(TB_Search.Text); }

        //при выборе строки задаем текущий объект
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        { 
            CurrentItem = dataGridView1.SelectedRows[0].Tag as ProductType;
            TB_ProductType.Text = CurrentItem.type;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект на основе введенных данных
                var item = new ProductType(MySqlConvert.ToNotNull(TB_ProductType.Text));
                //вкидываем его в бд
                Tables.product_type.Append(item);
                //обновляем данные
                Review();
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            //если строка не выбрана, то сообщаем об ошибке
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                try
                {
                    //иначе обновляем поле объетка
                    CurrentItem.type = MySqlConvert.ToNotNull(TB_ProductType.Text);
                    //обновляем его в бд
                    Tables.product_type.Update(CurrentItem);
                    Review(); //и обновляем отображаемые данные
                }
                catch (Exception ex) { Program.Log(ex); }
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            //если строка не выбрана, то сообщаем об ошибке
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                try
                {
                    //иначе удаляем объект из бд
                    Tables.product_type.Delete(CurrentItem);
                    Review(); //и обновляем данные
                }
                catch (Exception ex) { Program.Log(ex); }
            }
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else { Program.Copy(CurrentItem.row); }

        }
    }
}
