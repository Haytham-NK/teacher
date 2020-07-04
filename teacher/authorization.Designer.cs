namespace teacher
{
    partial class authorization
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
            this.bt_vhod = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_vhod
            // 
            this.bt_vhod.Location = new System.Drawing.Point(128, 155);
            this.bt_vhod.Name = "bt_vhod";
            this.bt_vhod.Size = new System.Drawing.Size(75, 23);
            this.bt_vhod.TabIndex = 0;
            this.bt_vhod.Text = "Вход";
            this.bt_vhod.UseVisualStyleBackColor = true;
            this.bt_vhod.Click += new System.EventHandler(this.bt_vhod_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(38, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(38, 13);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Логин";
            this.label_Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(38, 49);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(45, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Пароль";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(38, 88);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(24, 13);
            this.label_Type.TabIndex = 3;
            this.label_Type.Text = "тип";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Учитель",
            "Администратор"});
            this.cb_type.Location = new System.Drawing.Point(41, 104);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(100, 21);
            this.cb_type.TabIndex = 4;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(41, 26);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(41, 65);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 6;
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 186);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.bt_vhod);
            this.Name = "authorization";
            this.Text = "authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_vhod;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
    }
}