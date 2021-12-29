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
    //наследуемся от таблицы закупок
    //ввиду крайне схожей структуры
    public partial class FSale : FBuying
    {
        public FSale()
        {
            InitializeComponent();
            try
            {
                SetText(); Review();
                LoadDUDes();
            }
            catch
            { Program.Log(new Exception("Данные не инициализированы")); }
        }

        //переопределяем названия полей в интерфейса
        protected override void SetText()
        {
            this.Text = "Продажи";
            this.vendor.HeaderText = "Покупатель";
            this.label6.Text = "Покупатель";
            this.label4.Text = "Поиск по Покупателю:";
        }

        //переопределяем роль клиента на покупателя
        protected override bool role => false;

        //переопределяем рабочую таблицу на таблицу продаж
        protected override Table<Buying> table => Tables.sale;

        //переопределяем создание элемента на создание записи о продаже
        protected override Item CreateItem() => new Sale
        (
            DUD_Product.SelectedItem as ProductStore,
            TB_Quantity.Text.ToInt32(),
            DUD_Client.SelectedItem as Client,
            DUD_Worker.SelectedItem as Worker,
            DTP_Set.Value
        );
    }
}
