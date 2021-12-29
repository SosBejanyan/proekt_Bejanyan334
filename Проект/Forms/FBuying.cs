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
    public partial class FBuying : Form
    {
        public FBuying()
        {
            InitializeComponent();
            SetText(); Review();
            try { LoadDUDes(); }
            catch
            { Program.Log(new Exception("Данные не инициализированы")); }
        }

        //задаем названия полей в интерфейсе
        protected virtual void SetText()
        { 
            this.Text = "Закупки";
            this.vendor.HeaderText = "Поставшик";
            this.label6.Text = "Поставщик";
        }

        //задаем индексы выпадающих списков чтобы не словить исключение
        protected void LoadDUDes()
        {
            try
            {
                DUD_Product.SelectedIndex = 0;
                DUD_Client.SelectedIndex = 0;
                DUD_Worker.SelectedIndex = 0;
            }
            catch
            { Program.Log(new Exception("Данные не инициализированы")); }
        }

        //объект, с которым сейчас работает пользователь
        protected Buying CurrentItem;

        //таблица, с которой сейчас работает пользователь
        protected virtual Table<Buying> table => Tables.buying;

        //кэш поискового запроса
        private object[] search = new object[2] { "", 0 };

        //роль партнера (Поставщик)
        protected virtual bool role => true;

        //обновление отображаемых данных
        protected void Review(string search = "", int column = 0)
        {
            //очищаем все строки в таблице
            dataGridView1.Rows.Clear();
            //объявляем итоговую сумму сделок
            decimal allprice = 0M;

            //перебираем все элементы в таблице
            foreach(var item in table.GetAll())
            {
                //приводим к строке информацию об объекте
                string[] r = MySqlConvert.ToString(item.row);
                //форматируем данные в понятный пользователю формат
                r[1] = item.product_store.product_info.name;
                r[3] = item.cleint.name;
                r[4] = item.worker.ToString();
                string date = MySqlConvert.ToString(DTP_Search.Value);

                //суммируем стоимость сделок
                allprice += item.price;

                //переменная, отвечающая соответствию поискового запроса по дате
                bool d = !DateEnable.Checked || r[5].Contains(date);

                decimal first = TB_Price_Start.Text.ToDecimal();
                decimal end = TB_Price_End.Text.ToDecimal();

                //переменная, отвечающая соответствию поискового запроса по диапазону цен
                bool c = !PriceEnable.Checked || item.price.InRange(first, end);

                //если условия даты, цены и поиска удовлетворены
                if ((d & c) && r[column].ToLower().Contains(search.ToLower()))
                { 
                    //добавляем строку в таблицу
                    int index = dataGridView1.Rows.Add(r);
                    //добавляем элемент в контейнер строки
                    dataGridView1.Rows[index].Tag = item;
                }
            }
            
            //очищаем выпадающие списки
            DUD_Product.Items.Clear();
            DUD_Client.Items.Clear();
            DUD_Worker.Items.Clear();
            
            //и заполняем их
            foreach (var item in Tables.product_store.GetAll())
            { DUD_Product.Items.Add(item); }

            foreach (var item in Tables.clients.GetAll())
            { 
                if (item.BuyerSaler == role)
                DUD_Client.Items.Add(item);
            }

            foreach (var item in Tables.worker.GetAll())
            { DUD_Worker.Items.Add(item); }

            //кэшируем поисковый запрос
            this.search = new object[2] { search, column };
            //выводим общую сумму сделок
            Label_AllPrice.Text = $"Всего:  {allprice}"; 
            //высвобождаем неиспользуемые ресурсы
            Program.Clear();
        }

        //при нажатии на строку заполняем текущий объект 
        protected void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentItem = dataGridView1.SelectedRows[0].Tag as Buying;
                TB_Quantity.Text = CurrentItem.quantity.ToString();
                DUD_Product.SelectedItem = CurrentItem.product_store;
                DUD_Client.SelectedItem = CurrentItem.cleint;
                DUD_Worker.SelectedItem = CurrentItem.worker;
                DTP_Set.Value = CurrentItem.date;
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        //при изменении текста поискового запроса обновляем данные
        protected void SearchProduct(object sender, EventArgs e)
        { Review(TB_Search_Product.Text, 1); }

        protected void SearchVendor(object sender, EventArgs e)
        { Review(TB_Search_Vendor.Text, 3); }

        protected void SearchWorker(object sender, EventArgs e)
        { Review(TB_Search_Worker.Text, 4); }

        //очищаем все поля
        protected void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_Search_Product.Text = "";
            TB_Search_Vendor.Text = "";
            TB_Search_Worker.Text = "";
            Review();
        }

        protected void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект на основании введенных данных
                Buying item = this.CreateItem() as Buying;
                
                //производим расчет стоимости
                int q = TB_Quantity.Text.ToInt32();
                item.ComputePrice(q * 2);

                //вкидываем в бд и обновляем данные
                table.Append(item); Review();
            }
            catch (Exception ex) { Program.Log(ex); }
        }

        //заполнение объекта, может быть переорпделено в производном классе
        protected virtual Item CreateItem() => new Buying
                (
                    DUD_Product.SelectedItem as ProductStore,
                    TB_Quantity.Text.ToInt32(),
                    DUD_Client.SelectedItem as Client,
                    DUD_Worker.SelectedItem as Worker,
                    DTP_Set.Value
                );


        protected void BTN_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentItem == null)
                { Program.Log(Item.NotFound); }
                else
                {
                    //заполняем изменяемый элемент пользовательскими данными
                    int q = TB_Quantity.Text.ToInt32();
                    CurrentItem.product_store = DUD_Product.SelectedItem as ProductStore;
                    CurrentItem.cleint = DUD_Client.SelectedItem as Client;
                    CurrentItem.worker = DUD_Worker.SelectedItem as Worker;
                    CurrentItem.date = DTP_Set.Value;
                    CurrentItem.ComputePrice(q);
                    CurrentItem.quantity = q;

                    //обновляем его в бд и обновляем данные
                    table.Update(CurrentItem); Review();
                }
            }
            catch (Exception ex)
            { Program.Log(ex); }
        }

        protected void BTN_Delete_Click(object sender, EventArgs e)
        {
            //проверяем выбрана ли у нас строка
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else
            {
                //если да, то удаляем элемент и обновляем данные
                CurrentItem.ComputePrice(Int32.MinValue);
                table.Delete(CurrentItem); Review(); 
            }
        }

        //если элемент выбран, то копируем, иначе вообщем об ошибке
        protected void BTN_Copy_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null)
            { Program.Log(Item.NotFound); }
            else { Program.Copy(CurrentItem.row); }
        }

        //очищаем поля диапазона цен
        protected void button1_Click(object sender, EventArgs e)
        {
            TB_Price_End.Text = "";
            TB_Price_Start.Text = "";
            Review();
        }

        //поик по ценовому диапазону
        protected void SearchPrice(object sender, EventArgs e)
        { Review(search[0].ToString(), search[1].ToInt32()); }
    }
}
