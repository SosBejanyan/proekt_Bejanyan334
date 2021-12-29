namespace Storage2.Forms
{
    partial class FClient
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
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Search_Notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Search_FIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Search_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_PostIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerSaler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Search_Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(1279, 210);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(167, 23);
            this.BTN_Clear.TabIndex = 57;
            this.BTN_Clear.Text = "Очистить Запросы";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1279, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Поиск по Описанию:";
            // 
            // TB_Search_Notes
            // 
            this.TB_Search_Notes.Location = new System.Drawing.Point(1279, 115);
            this.TB_Search_Notes.Name = "TB_Search_Notes";
            this.TB_Search_Notes.Size = new System.Drawing.Size(167, 20);
            this.TB_Search_Notes.TabIndex = 55;
            this.TB_Search_Notes.TextChanged += new System.EventHandler(this.SearchNotes);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1279, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Поиск по ФИО:";
            // 
            // TB_Search_FIO
            // 
            this.TB_Search_FIO.Location = new System.Drawing.Point(1279, 76);
            this.TB_Search_FIO.Name = "TB_Search_FIO";
            this.TB_Search_FIO.Size = new System.Drawing.Size(167, 20);
            this.TB_Search_FIO.TabIndex = 53;
            this.TB_Search_FIO.TextChanged += new System.EventHandler(this.SearchFIO);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1279, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Поиск по Названию:";
            // 
            // TB_Search_Name
            // 
            this.TB_Search_Name.Location = new System.Drawing.Point(1279, 30);
            this.TB_Search_Name.Name = "TB_Search_Name";
            this.TB_Search_Name.Size = new System.Drawing.Size(167, 20);
            this.TB_Search_Name.TabIndex = 51;
            this.TB_Search_Name.TextChanged += new System.EventHandler(this.SearchName);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1279, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Почтовый индекс:";
            // 
            // TB_PostIndex
            // 
            this.TB_PostIndex.Location = new System.Drawing.Point(1279, 397);
            this.TB_PostIndex.Name = "TB_PostIndex";
            this.TB_PostIndex.Size = new System.Drawing.Size(167, 20);
            this.TB_PostIndex.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1279, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Адрес:";
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(1279, 350);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(167, 20);
            this.TB_Address.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1279, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "ФИО:";
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(1279, 304);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(167, 20);
            this.TB_FIO.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1279, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Название:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(1279, 261);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(167, 20);
            this.TB_Name.TabIndex = 42;
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(1370, 625);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 39;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(1279, 625);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 38;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(1370, 596);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 37;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(1279, 596);
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
            this.name,
            this.owner_fio,
            this.address,
            this.post_index,
            this.phone,
            this.email,
            this.BuyerSaler,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 637);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 46;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 146;
            // 
            // owner_fio
            // 
            this.owner_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owner_fio.HeaderText = "ФИО";
            this.owner_fio.Name = "owner_fio";
            this.owner_fio.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 146;
            // 
            // post_index
            // 
            this.post_index.HeaderText = "Почтовый индекс";
            this.post_index.Name = "post_index";
            this.post_index.ReadOnly = true;
            this.post_index.Width = 140;
            // 
            // phone
            // 
            this.phone.HeaderText = "Сотовый номер";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 140;
            // 
            // email
            // 
            this.email.HeaderText = "Электронная почта";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 140;
            // 
            // BuyerSaler
            // 
            this.BuyerSaler.HeaderText = "Роль";
            this.BuyerSaler.Name = "BuyerSaler";
            this.BuyerSaler.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.HeaderText = "Примечание";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1279, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Электронная почта:";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(1279, 491);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(169, 20);
            this.TB_Email.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1279, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Сотовый номер:";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(1279, 444);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(167, 20);
            this.TB_Phone.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1279, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Примечание:";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(1279, 534);
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(169, 20);
            this.TB_Notes.TabIndex = 62;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1283, 560);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 64;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Поставщик";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1363, 560);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 65;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Покупатель";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("все партнеры");
            this.domainUpDown1.Items.Add("только поставщики");
            this.domainUpDown1.Items.Add("только покупатели");
            this.domainUpDown1.Location = new System.Drawing.Point(1279, 184);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(167, 20);
            this.domainUpDown1.TabIndex = 66;
            this.domainUpDown1.Text = "Отображение";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.SearchType);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1279, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Поиск по Адресу:";
            // 
            // TB_Search_Address
            // 
            this.TB_Search_Address.Location = new System.Drawing.Point(1279, 158);
            this.TB_Search_Address.Name = "TB_Search_Address";
            this.TB_Search_Address.Size = new System.Drawing.Size(167, 20);
            this.TB_Search_Address.TabIndex = 67;
            this.TB_Search_Address.TextChanged += new System.EventHandler(SearchAddress);
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_Search_Address);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_Notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Phone);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_Search_Notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Search_FIO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Search_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_PostIndex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FClient";
            this.Text = "Партнеры";
            this.Load += new System.EventHandler(this.FClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Search_Notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Search_FIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Search_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_PostIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerSaler;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_Search_Address;
    }
}