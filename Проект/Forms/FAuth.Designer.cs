namespace Storage2.Forms
{
    partial class FAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Init = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_DataBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.TB_ConnectionString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BTN_Init
            // 
            this.BTN_Init.Location = new System.Drawing.Point(118, 119);
            this.BTN_Init.Name = "BTN_Init";
            this.BTN_Init.Size = new System.Drawing.Size(102, 23);
            this.BTN_Init.TabIndex = 21;
            this.BTN_Init.Text = "войти в систему";
            this.BTN_Init.UseVisualStyleBackColor = true;
            this.BTN_Init.Click += new System.EventHandler(this.BTN_Init_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "База данных:";
            // 
            // TB_DataBase
            // 
            this.TB_DataBase.Location = new System.Drawing.Point(12, 122);
            this.TB_DataBase.Name = "TB_DataBase";
            this.TB_DataBase.Size = new System.Drawing.Size(100, 20);
            this.TB_DataBase.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Пароль:";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(118, 76);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Логин:";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(12, 76);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(100, 20);
            this.TB_Login.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Порт сервера:";
            // 
            // TB_Port
            // 
            this.TB_Port.Location = new System.Drawing.Point(118, 31);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Size = new System.Drawing.Size(100, 20);
            this.TB_Port.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Адрес сервера:";
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(12, 31);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(100, 20);
            this.TB_IP.TabIndex = 11;
            // 
            // TB_ConnectionString
            // 
            this.TB_ConnectionString.Location = new System.Drawing.Point(12, 165);
            this.TB_ConnectionString.Name = "TB_ConnectionString";
            this.TB_ConnectionString.Size = new System.Drawing.Size(206, 20);
            this.TB_ConnectionString.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Строка подключения (если есть):";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(12, 191);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(97, 23);
            this.BTN_Clear.TabIndex = 24;
            this.BTN_Clear.Text = "очистить";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Создать БД";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 218);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_ConnectionString);
            this.Controls.Add(this.BTN_Init);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_DataBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FAuth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Init;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_DataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.TextBox TB_ConnectionString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

