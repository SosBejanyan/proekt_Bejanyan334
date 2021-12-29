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
    public partial class FWorker : Form
    {
        public FWorker()
        {
            InitializeComponent();
            Review();
        }

        //текущий объект, с которым работает пользователь
        private Worker CurrentItem;

        //кэш поискового запроса
        private object[] search = new object[2] { "", 1 };

        //обновление данных на основе поискового запроса по колонке
        private void Review(string search = "", int column = 1)
        {
            //очищаем таблицу
            dataGridView1.Rows.Clear();
            //перебираем все элементы, отвечающие запросу
            foreach (var item in Tables.worker.Search(search, column))
            {
                if (!isInternal_Search.Checked || item.is_internal)
                {
                    object[] r = item.row;
                    r[1] = MySqlConvert.ToInitials(r[1]);
                    r[5] = MySqlConvert.ToString(item.is_internal);
                    //заносим форматированные данные в таблицу
                    int index = dataGridView1.Rows.Add(r);
                    //вкидываем сам элемент в тэг
                    dataGridView1.Rows[index].Tag = item;
                }
            }
            Program.Clear();//чистим память
        }

        private void SearchFIO(object sender, EventArgs e)
        { 
            search = new object[] { TB_Search_FIO.Text, 1};
            Review(search[0].ToString(), search[1].ToInt32());
        }

        private void SearchRole(object sender, EventArgs e)
        {
            search = new object[] { TB_Search_Role.Text, 2 };
            Review(search[0].ToString(), search[1].ToInt32());
        }

        private void SearchInternal(object sender, EventArgs e)
        { Review(search[0].ToString(), search[1].ToInt32()); }

        //при выборе строки задаем текущий объект
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentItem = dataGridView1.SelectedRows[0].Tag as Worker;
                TB_FIO.Text = CurrentItem.fio;
                TB_Role.Text = CurrentItem.role;
                TB_Phone.Text = CurrentItem.phone.ToString();
                TB_Email.Text = CurrentItem.email;
                IsInternal_Set.Checked = CurrentItem.is_internal;
            }
            catch { Program.Log(Item.NotFound); }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_Search_FIO.Text = "";
            TB_Search_Role.Text = "";
            isInternal_Search.Checked = false;
            this.search = new object[2] { "", 1 };
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new Worker
                (
                    MySqlConvert.ToNotNull(TB_FIO.Text),
                    TB_Role.Text,
                    TB_Phone.Text.ToInt64(),
                    TB_Email.Text,
                    IsInternal_Set.Checked
                );
                Tables.worker.Append(item); Review();
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                try
                {
                    CurrentItem.fio = MySqlConvert.ToNotNull(TB_FIO.Text);
                    CurrentItem.role = TB_Role.Text;
                    CurrentItem.phone = TB_Phone.Text.ToInt64();
                    CurrentItem.email = TB_Email.Text;
                    CurrentItem.is_internal = IsInternal_Set.Checked;
                    Tables.worker.Update(CurrentItem); Review();
                }
                catch (Exception ex) { Program.Log(ex); }
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                try { Tables.worker.Delete(CurrentItem); Review(); }
                catch(Exception ex) { Program.Log(ex); }
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
