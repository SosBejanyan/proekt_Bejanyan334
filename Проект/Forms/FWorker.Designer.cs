namespace Storage2.Forms
{
    partial class FWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Search_FIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Role = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.BTN_Copy = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_internal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInternal_Search = new System.Windows.Forms.CheckBox();
            this.IsInternal_Set = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Search_Role = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Электронная почта:";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(974, 439);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(153, 20);
            this.TB_Email.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(974, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Сотовый номер:";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(974, 392);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(153, 20);
            this.TB_Phone.TabIndex = 84;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(974, 127);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(153, 23);
            this.BTN_Clear.TabIndex = 83;
            this.BTN_Clear.Text = "Очистить Запросы";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(974, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Поиск по ФИО:";
            // 
            // TB_Search_FIO
            // 
            this.TB_Search_FIO.Location = new System.Drawing.Point(974, 26);
            this.TB_Search_FIO.Name = "TB_Search_FIO";
            this.TB_Search_FIO.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_FIO.TabIndex = 79;
            this.TB_Search_FIO.TextChanged += new System.EventHandler(this.SearchFIO);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(974, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Должность:";
            // 
            // TB_Role
            // 
            this.TB_Role.Location = new System.Drawing.Point(974, 353);
            this.TB_Role.Name = "TB_Role";
            this.TB_Role.Size = new System.Drawing.Size(153, 20);
            this.TB_Role.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(974, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "ФИО:";
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(974, 307);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(153, 20);
            this.TB_FIO.TabIndex = 71;
            // 
            // BTN_Copy
            // 
            this.BTN_Copy.Location = new System.Drawing.Point(1049, 546);
            this.BTN_Copy.Name = "BTN_Copy";
            this.BTN_Copy.Size = new System.Drawing.Size(78, 23);
            this.BTN_Copy.TabIndex = 68;
            this.BTN_Copy.Text = "Копировать";
            this.BTN_Copy.UseVisualStyleBackColor = true;
            this.BTN_Copy.Click += new System.EventHandler(this.BTN_Copy_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(974, 546);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(69, 23);
            this.BTN_Delete.TabIndex = 67;
            this.BTN_Delete.Text = "Удалить";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(1049, 517);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(78, 23);
            this.BTN_Edit.TabIndex = 66;
            this.BTN_Edit.Text = "Изменить";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(974, 517);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(69, 23);
            this.BTN_Add.TabIndex = 65;
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
            this.owner_fio,
            this.role,
            this.phone,
            this.email,
            this.is_internal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 559);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 66;
            // 
            // owner_fio
            // 
            this.owner_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owner_fio.HeaderText = "ФИО";
            this.owner_fio.Name = "owner_fio";
            this.owner_fio.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Должность";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 146;
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
            // is_internal
            // 
            this.is_internal.HeaderText = "Наш человек";
            this.is_internal.Name = "is_internal";
            this.is_internal.ReadOnly = true;
            this.is_internal.Width = 180;
            // 
            // isInternal_Search
            // 
            this.isInternal_Search.AutoSize = true;
            this.isInternal_Search.Location = new System.Drawing.Point(974, 104);
            this.isInternal_Search.Name = "isInternal_Search";
            this.isInternal_Search.Size = new System.Drawing.Size(153, 17);
            this.isInternal_Search.TabIndex = 90;
            this.isInternal_Search.Text = "Только наши сотрудники";
            this.isInternal_Search.UseVisualStyleBackColor = true;
            this.isInternal_Search.CheckedChanged += new System.EventHandler(this.SearchInternal);
            // 
            // IsInternal_Set
            // 
            this.IsInternal_Set.AutoSize = true;
            this.IsInternal_Set.Location = new System.Drawing.Point(974, 479);
            this.IsInternal_Set.Name = "IsInternal_Set";
            this.IsInternal_Set.Size = new System.Drawing.Size(92, 17);
            this.IsInternal_Set.TabIndex = 91;
            this.IsInternal_Set.Text = "Наш человек";
            this.IsInternal_Set.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(974, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Поиск по Должности:";
            // 
            // TB_Search_Role
            // 
            this.TB_Search_Role.Location = new System.Drawing.Point(974, 71);
            this.TB_Search_Role.Name = "TB_Search_Role";
            this.TB_Search_Role.Size = new System.Drawing.Size(153, 20);
            this.TB_Search_Role.TabIndex = 92;
            this.TB_Search_Role.TextChanged += new System.EventHandler(this.SearchRole);
            // 
            // FWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Search_Role);
            this.Controls.Add(this.IsInternal_Set);
            this.Controls.Add(this.isInternal_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Phone);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Search_FIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.BTN_Copy);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FWorker";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Search_FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.Button BTN_Copy;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox isInternal_Search;
        private System.Windows.Forms.CheckBox IsInternal_Set;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Search_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_internal;
    }
}