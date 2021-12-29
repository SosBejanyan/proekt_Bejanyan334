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
    public partial class FProductStore : Form
    {
        public FProductStore()
        {
            InitializeComponent();
            Review();
            domainUpDown1.SelectedIndex = 0;
        }
        //текущий объект, с которым работает пользователь
        private ProductStore CurrentItem;

        //обновление данных на основе поискового запроса
        private void Review(string search="")
        {
            dataGridView1.Rows.Clear();
            search = search.ToLower();
            foreach(var item in Tables.product_store.GetAll())
            {
                bool supplied = !isSupplied_Search.Checked || item.is_supplied;

                if (supplied && item.product_info.name.ToLower().Contains(search))
                {
                    object[] row = item.row;
                    row[1] = item.product_info.name;
                    row[3] = MySqlConvert.ToString(item.is_supplied);
                    int index = dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[index].Tag = item;
                }
            }

            domainUpDown1.Items.Clear();
            foreach (var item in Tables.product_info.GetAll())
            { domainUpDown1.Items.Add(item); }
            Program.Clear();
        }

        //осуществляем поиск при изменении текстбокса
        private void Search(object sender, EventArgs e)
        { Review(TB_Search_Info.Text); }

        //при нажатии на строку достаем из нее объект и заполняем поля его данными
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            CurrentItem = dataGridView1.SelectedRows[0].Tag as ProductStore;
            domainUpDown1.SelectedItem = CurrentItem.product_info;
            TB_Quantity.Text = CurrentItem.quantity.ToString();
            isSupplied_AddEdit.Checked = CurrentItem.is_supplied;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект на основании введенных данных
                var item = new ProductStore
                (
                    domainUpDown1.SelectedItem as ProductInfo,
                    Int32.Parse(TB_Quantity.Text),
                    isSupplied_AddEdit.Checked
                );
                //вкидываем его в бд
                Tables.product_store.Append(item);
                Review(); //и обновляем данные
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                //если строка не выбрана, то сообщаем об ошибке
                if (CurrentItem == null)
                { Program.Log(Item.NotFound); }
                else
                {
                    //иначе обновляем поля объекта
                    CurrentItem.product_info = domainUpDown1.SelectedItem as ProductInfo;
                    CurrentItem.quantity = Int32.Parse(MySqlConvert.ToNotNull(TB_Quantity.Text));
                    CurrentItem.is_supplied = isSupplied_AddEdit.Checked;

                    //обновляем объект в бд и обновляем данные
                    Tables.product_store.Update(CurrentItem); Review();
                }
            }
            catch (Exception ex) { Program.Log(ex); }
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
                    Tables.product_store.Delete(CurrentItem);
                    Review(); //и обновляем данные
                }
                catch (Exception ex) { Program.Log(ex); }
            }
        }

        private void BTN_Copy_Click(object sender, EventArgs e)
        {
            //если строка не выбрана, то сообщаем об ошибке
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            //иначе копируем объект в буфур обмена
            else { Program.Copy(CurrentItem.row); }
        }

        //очищаем поле поиска и обновляем данные
        private void BTN_Clear_Click(object sender, EventArgs e)
        { TB_Search_Info.Text = ""; Review(); }
    }
}
