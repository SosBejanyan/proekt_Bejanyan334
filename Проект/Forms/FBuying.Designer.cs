namespace Storage2.Forms
{
    partial class FBuying
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.DUD_Product = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.TB_Search_Product = new System.Windows.Forms.TextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Search_Vendor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Search_Worker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DUD_Client = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DUD_Worker = new System.Windows.Forms.DomainUpDown();
            this.DTP_Set = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DTP_Search = new System.Windows.Forms.DateTimePicker();
            this.DateEnable = new System.Windows.Forms.CheckBox();
            this.Label_AllPrice = new System.Windows.Forms.Label();
            this.PriceEnable = new System.Windows.Forms.CheckBox();
            this.TB_Price_Start = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Price_End = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(1077, 286);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(156, 23);
            this.BTN_Clear.TabIndex = 71;
            this.BTN_Clear.Text = "Очистить Запрос";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // DUD_Product
            // 
            this.DUD_Product.Location = new System.Drawing.Point(1081, 342);
            this.DUD_Product.Name = "DUD_Product";
            this.DUD_Product.Size = new System.Drawing.Size(153, 20);
            this.DUD_Product.TabIndex = 70;
            this.DUD_Product.Text = "Выберите вид";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1081, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Количество Товара:";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.Location = new System.Drawing.Point(1081, 385);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(153, 20);
            this.TB_Quantity.TabIndex = 68;
            // 
            // TB_Search_Product
            // 
            this.TB_Search_Product.Location = new System.Drawing.Point(1081, 29);
            this.TB_Search_Product.Name = "TB_Search_Product";
            this.TB_Search_Product.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Product.TabIndex = 66;
            this.TB_Search_Product.TextChanged += new System.EventHandler(this.SearchProduct);
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(1156, 600);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 65;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(1081, 600);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 64;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(1156, 571);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 63;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1081, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Вид Товара:";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(1081, 571);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(69, 23);
            this.BTN_Add.TabIndex = 61;
            this.BTN_Add.Text = "Добавить";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product_store,
            this.quantity,
            this.vendor,
            this.worker,
            this.date,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 611);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 66;
            // 
            // product_store
            // 
            this.product_store.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_store.HeaderText = "Товар";
            this.product_store.Name = "product_store";
            this.product_store.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantity.HeaderText = "Количество Товара";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 146;
            // 
            // vendor
            // 
            this.vendor.HeaderText = "Поставщик";
            this.vendor.Name = "vendor";
            this.vendor.ReadOnly = true;
            this.vendor.Width = 186;
            // 
            // worker
            // 
            this.worker.HeaderText = "Сотрудник";
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            this.worker.Width = 220;
            // 
            // date
            // 
            this.date.HeaderText = "Дата сделки";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 140;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1081, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Поиск по Товару:";
            // 
            // TB_Search_Vendor
            // 
            this.TB_Search_Vendor.Location = new System.Drawing.Point(1081, 72);
            this.TB_Search_Vendor.Name = "TB_Search_Vendor";
            this.TB_Search_Vendor.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Vendor.TabIndex = 74;
            this.TB_Search_Vendor.TextChanged += new System.EventHandler(this.SearchVendor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1081, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Поиск по Поставщику:";
            // 
            // TB_Search_Worker
            // 
            this.TB_Search_Worker.Location = new System.Drawing.Point(1081, 116);
            this.TB_Search_Worker.Name = "TB_Search_Worker";
            this.TB_Search_Worker.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Worker.TabIndex = 76;
            this.TB_Search_Worker.TextChanged += new System.EventHandler(this.SearchWorker);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1081, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Поиск по Сотруднику:";
            // 
            // DUD_Client
            // 
            this.DUD_Client.Location = new System.Drawing.Point(1081, 433);
            this.DUD_Client.Name = "DUD_Client";
            this.DUD_Client.Size = new System.Drawing.Size(153, 20);
            this.DUD_Client.TabIndex = 79;
            this.DUD_Client.Text = "Выберите название";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1081, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Поставщик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1081, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Сотрудник:";
            // 
            // DUD_Worker
            // 
            this.DUD_Worker.Location = new System.Drawing.Point(1081, 484);
            this.DUD_Worker.Name = "DUD_Worker";
            this.DUD_Worker.Size = new System.Drawing.Size(153, 20);
            this.DUD_Worker.TabIndex = 81;
            this.DUD_Worker.Text = "Выберите фио";
            // 
            // DTP_Set
            // 
            this.DTP_Set.Location = new System.Drawing.Point(1080, 531);
            this.DTP_Set.Name = "DTP_Set";
            this.DTP_Set.Size = new System.Drawing.Size(153, 20);
            this.DTP_Set.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1081, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Дата поставки:";
            // 
            // DTP_Search
            // 
            this.DTP_Search.Location = new System.Drawing.Point(1080, 173);
            this.DTP_Search.Name = "DTP_Search";
            this.DTP_Search.Size = new System.Drawing.Size(153, 20);
            this.DTP_Search.TabIndex = 84;
            // 
            // DateEnable
            // 
            this.DateEnable.AutoSize = true;
            this.DateEnable.Location = new System.Drawing.Point(1081, 153);
            this.DateEnable.Name = "DateEnable";
            this.DateEnable.Size = new System.Drawing.Size(105, 17);
            this.DateEnable.TabIndex = 86;
            this.DateEnable.Text = "Поиск по Дате:";
            this.DateEnable.UseVisualStyleBackColor = true;
            // 
            // Label_AllPrice
            // 
            this.Label_AllPrice.BackColor = System.Drawing.Color.White;
            this.Label_AllPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_AllPrice.Location = new System.Drawing.Point(1078, 265);
            this.Label_AllPrice.Name = "Label_AllPrice";
            this.Label_AllPrice.Size = new System.Drawing.Size(155, 18);
            this.Label_AllPrice.TabIndex = 87;
            this.Label_AllPrice.Text = "Всего:";
            // 
            // PriceEnable
            // 
            this.PriceEnable.AutoSize = true;
            this.PriceEnable.Location = new System.Drawing.Point(1082, 206);
            this.PriceEnable.Name = "PriceEnable";
            this.PriceEnable.Size = new System.Drawing.Size(124, 17);
            this.PriceEnable.TabIndex = 88;
            this.PriceEnable.Text = "Ценовой диапазон:";
            this.PriceEnable.UseVisualStyleBackColor = true;
            this.PriceEnable.CheckedChanged += new System.EventHandler(this.SearchPrice);
            // 
            // TB_Price_Start
            // 
            this.TB_Price_Start.Location = new System.Drawing.Point(1080, 229);
            this.TB_Price_Start.Name = "TB_Price_Start";
            this.TB_Price_Start.Size = new System.Drawing.Size(64, 20);
            this.TB_Price_Start.TabIndex = 89;
            this.TB_Price_Start.Text = "0";
            this.TB_Price_Start.TextChanged += new System.EventHandler(SearchPrice);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1146, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 26);
            this.label11.TabIndex = 90;
            this.label11.Text = "-";
            // 
            // TB_Price_End
            // 
            this.TB_Price_End.Location = new System.Drawing.Point(1167, 229);
            this.TB_Price_End.Name = "TB_Price_End";
            this.TB_Price_End.Size = new System.Drawing.Size(64, 20);
            this.TB_Price_End.TabIndex = 91;
            this.TB_Price_End.Text = "999999999";
            this.TB_Price_End.TextChanged += new System.EventHandler(SearchPrice);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1207, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 17);
            this.button1.TabIndex = 92;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FBuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Price_End);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_Price_Start);
            this.Controls.Add(this.PriceEnable);
            this.Controls.Add(this.Label_AllPrice);
            this.Controls.Add(this.DateEnable);
            this.Controls.Add(this.DTP_Search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_Set);
            this.Controls.Add(this.DUD_Worker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DUD_Client);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Search_Worker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Search_Vendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.DUD_Product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Quantity);
            this.Controls.Add(this.TB_Search_Product);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FBuying";
            this.Text = "FBuying";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button BTN_Clear;
        protected System.Windows.Forms.DomainUpDown DUD_Product;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox TB_Quantity;
        protected System.Windows.Forms.TextBox TB_Search_Product;
        protected System.Windows.Forms.Button BTN_Copy;
        protected System.Windows.Forms.Button BTN_Delete;
        protected System.Windows.Forms.Button BTN_Edit;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button BTN_Add;
        protected System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox TB_Search_Vendor;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox TB_Search_Worker;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.DomainUpDown DUD_Client;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.DomainUpDown DUD_Worker;
        protected System.Windows.Forms.DateTimePicker DTP_Set;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DateTimePicker DTP_Search;
        protected System.Windows.Forms.CheckBox DateEnable;
        protected System.Windows.Forms.Label Label_AllPrice;
        protected System.Windows.Forms.CheckBox PriceEnable;
        protected System.Windows.Forms.TextBox TB_Price_Start;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.TextBox TB_Price_End;
        protected System.Windows.Forms.DataGridViewTextBoxColumn id;
        protected System.Windows.Forms.DataGridViewTextBoxColumn product_store;
        protected System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        protected System.Windows.Forms.DataGridViewTextBoxColumn vendor;
        protected System.Windows.Forms.DataGridViewTextBoxColumn worker;
        protected System.Windows.Forms.DataGridViewTextBoxColumn date;
        protected System.Windows.Forms.DataGridViewTextBoxColumn price;
        protected System.Windows.Forms.Button button1;
    }
}