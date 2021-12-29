namespace Storage2.Forms
{
    partial class FProductStore
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
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Quantity = new System.Windows.Forms.TextBox();
            this.TB_Search_Info = new System.Windows.Forms.TextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.isSupplied_Search = new System.Windows.Forms.CheckBox();
            this.isSupplied_AddEdit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(671, 78);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(153, 23);
            this.BTN_Clear.TabIndex = 57;
            this.BTN_Clear.Text = "Очистить Запрос";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(671, 357);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(153, 20);
            this.domainUpDown1.TabIndex = 44;
            this.domainUpDown1.Text = "Выберите вид";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Количество Товара:";
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.Location = new System.Drawing.Point(671, 404);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(153, 20);
            this.TB_Quantity.TabIndex = 42;
            // 
            // TB_Search_Info
            // 
            this.TB_Search_Info.Location = new System.Drawing.Point(671, 29);
            this.TB_Search_Info.Name = "TB_Search_Info";
            this.TB_Search_Info.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Info.TabIndex = 40;
            this.TB_Search_Info.TextChanged += new System.EventHandler(this.Search);
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(746, 487);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 39;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(671, 487);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 38;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(746, 458);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 37;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Вид Товара:";
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(671, 458);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(69, 23);
            this.BTN_Add.TabIndex = 35;
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
            this.product_info,
            this.quantity,
            this.brand});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 498);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 66;
            // 
            // product_info
            // 
            this.product_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_info.HeaderText = "Вид Товара";
            this.product_info.Name = "product_info";
            this.product_info.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantity.HeaderText = "Количество Товара";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 146;
            // 
            // brand
            // 
            this.brand.HeaderText = "Посталвяется";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Поиск по Виду:";
            // 
            // isSupplied_Search
            // 
            this.isSupplied_Search.AutoSize = true;
            this.isSupplied_Search.Location = new System.Drawing.Point(675, 55);
            this.isSupplied_Search.Name = "isSupplied_Search";
            this.isSupplied_Search.Size = new System.Drawing.Size(141, 17);
            this.isSupplied_Search.TabIndex = 58;
            this.isSupplied_Search.Text = "Только поставляемые";
            this.isSupplied_Search.UseVisualStyleBackColor = true;
            this.isSupplied_Search.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // isSupplied_AddEdit
            // 
            this.isSupplied_AddEdit.AutoSize = true;
            this.isSupplied_AddEdit.Location = new System.Drawing.Point(671, 430);
            this.isSupplied_AddEdit.Name = "isSupplied_AddEdit";
            this.isSupplied_AddEdit.Size = new System.Drawing.Size(137, 17);
            this.isSupplied_AddEdit.TabIndex = 59;
            this.isSupplied_AddEdit.Text = "Сейчас Поставляется";
            this.isSupplied_AddEdit.UseVisualStyleBackColor = true;
            // 
            // FProductStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 519);
            this.Controls.Add(this.isSupplied_AddEdit);
            this.Controls.Add(this.isSupplied_Search);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Quantity);
            this.Controls.Add(this.TB_Search_Info);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FProductStore";
            this.Text = "Товары на Складе";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Quantity;
        private System.Windows.Forms.TextBox TB_Search_Info;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.CheckBox isSupplied_Search;
        private System.Windows.Forms.CheckBox isSupplied_AddEdit;
    }
}