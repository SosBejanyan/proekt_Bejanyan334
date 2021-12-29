namespace Storage2.Forms
{
    partial class FProductType
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_ProductType = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product_type});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 86;
            // 
            // product_type
            // 
            this.product_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_type.HeaderText = "Тип Товара";
            this.product_type.Name = "product_type";
            this.product_type.ReadOnly = true;
            // 
            // TB_ProductType
            // 
            this.TB_ProductType.Location = new System.Drawing.Point(652, 278);
            this.TB_ProductType.Name = "TB_ProductType";
            this.TB_ProductType.Size = new System.Drawing.Size(153, 20);
            this.TB_ProductType.TabIndex = 1;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(652, 304);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(69, 23);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Добавить";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип Товара:";
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(727, 304);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 4;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(652, 333);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 5;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(727, 333);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 6;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(652, 28);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(153, 20);
            this.TB_Search.TabIndex = 7;
            this.TB_Search.TextChanged += new System.EventHandler(this.Search);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поиск:";
            // 
            // FProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.TB_ProductType);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FProductType";
            this.Text = "Типы Товаров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB_ProductType;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
    }
}