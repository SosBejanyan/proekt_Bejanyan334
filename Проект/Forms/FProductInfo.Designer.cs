namespace Storage2.Forms
{
    partial class FProductInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Search_Type = new System.Windows.Forms.TextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Brand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Decription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Cost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Search_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Search_Brand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Search_Description = new System.Windows.Forms.TextBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Поиск по Типу:";
            // 
            // TB_Search_Type
            // 
            this.TB_Search_Type.Location = new System.Drawing.Point(866, 30);
            this.TB_Search_Type.Name = "TB_Search_Type";
            this.TB_Search_Type.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Type.TabIndex = 16;
            this.TB_Search_Type.TextChanged += new System.EventHandler(this.SearchType);
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(941, 546);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 15;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(866, 546);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 14;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(941, 517);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 13;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тип Товара:";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(866, 517);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(69, 23);
            this.BTN_Add.TabIndex = 11;
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
            this.product_type,
            this.name,
            this.brand,
            this.description,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 559);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 66;
            // 
            // product_type
            // 
            this.product_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.product_type.HeaderText = "Тип Товара";
            this.product_type.Name = "product_type";
            this.product_type.ReadOnly = true;
            this.product_type.Width = 106;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Название Товара";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "Марка Товара";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 136;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(866, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название Товара:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(866, 343);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(153, 20);
            this.TB_Name.TabIndex = 18;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(866, 296);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(153, 20);
            this.domainUpDown1.TabIndex = 20;
            this.domainUpDown1.Text = "Выберите тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Марка Товара:";
            // 
            // TB_Brand
            // 
            this.TB_Brand.Location = new System.Drawing.Point(866, 386);
            this.TB_Brand.Name = "TB_Brand";
            this.TB_Brand.Size = new System.Drawing.Size(153, 20);
            this.TB_Brand.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(866, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Описание Товара:";
            // 
            // TB_Decription
            // 
            this.TB_Decription.Location = new System.Drawing.Point(866, 432);
            this.TB_Decription.Name = "TB_Decription";
            this.TB_Decription.Size = new System.Drawing.Size(153, 20);
            this.TB_Decription.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Цена Товара:";
            // 
            // TB_Cost
            // 
            this.TB_Cost.Location = new System.Drawing.Point(866, 479);
            this.TB_Cost.Name = "TB_Cost";
            this.TB_Cost.Size = new System.Drawing.Size(153, 20);
            this.TB_Cost.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(866, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Поиск по Названию:";
            // 
            // TB_Search_Name
            // 
            this.TB_Search_Name.Location = new System.Drawing.Point(866, 80);
            this.TB_Search_Name.Name = "TB_Search_Name";
            this.TB_Search_Name.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Name.TabIndex = 27;
            this.TB_Search_Name.TextChanged += new System.EventHandler(this.SearchName);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(866, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Поиск по Марке:";
            // 
            // TB_Search_Brand
            // 
            this.TB_Search_Brand.Location = new System.Drawing.Point(866, 129);
            this.TB_Search_Brand.Name = "TB_Search_Brand";
            this.TB_Search_Brand.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Brand.TabIndex = 29;
            this.TB_Search_Brand.TextChanged += new System.EventHandler(this.SearchBrand);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(866, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Поиск по Описанию:";
            // 
            // TB_Search_Description
            // 
            this.TB_Search_Description.Location = new System.Drawing.Point(866, 179);
            this.TB_Search_Description.Name = "TB_Search_Description";
            this.TB_Search_Description.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Description.TabIndex = 31;
            this.TB_Search_Description.TextChanged += new System.EventHandler(this.SearchDescription);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(866, 209);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(153, 23);
            this.BTN_Clear.TabIndex = 33;
            this.BTN_Clear.Text = "Очистить Запросы";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // FProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 583);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_Search_Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Search_Brand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Search_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Decription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Brand);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Search_Type);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FProductInfo";
            this.Text = "Информация о Товарах";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Search_Type;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Brand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Decription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Search_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Search_Brand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Search_Description;
        private System.Windows.Forms.Button BTN_Clear;
    }
}