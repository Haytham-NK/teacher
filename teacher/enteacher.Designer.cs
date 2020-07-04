namespace teacher
{
    partial class enteacher
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
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ListViewTeachers = new System.Windows.Forms.ListView();
            this.LabelName = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(648, 342);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 46;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(567, 342);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 45;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(486, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 44;
            this.btn_Add.Text = "Создать";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ListViewTeachers
            // 
            this.ListViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12});
            this.ListViewTeachers.HideSelection = false;
            this.ListViewTeachers.Location = new System.Drawing.Point(139, 12);
            this.ListViewTeachers.Name = "ListViewTeachers";
            this.ListViewTeachers.Size = new System.Drawing.Size(581, 324);
            this.ListViewTeachers.TabIndex = 36;
            this.ListViewTeachers.UseCompatibleStateImageBehavior = false;
            this.ListViewTeachers.View = System.Windows.Forms.View.Details;
            this.ListViewTeachers.SelectedIndexChanged += new System.EventHandler(this.ListViewTeachers_SelectedIndexChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(5, 51);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 41;
            this.LabelName.Text = "Имя";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(5, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 39;
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.Location = new System.Drawing.Point(5, 106);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(100, 20);
            this.tb_patronymic.TabIndex = 38;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(5, 28);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 37;
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Location = new System.Drawing.Point(2, 90);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.LabelPatronymic.TabIndex = 43;
            this.LabelPatronymic.Text = "Отчество";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(5, 12);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(56, 13);
            this.LabelSurname.TabIndex = 40;
            this.LabelSurname.Text = "Фамилия";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 0;
            this.columnHeader3.Text = "Логин";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Пароль";
            this.columnHeader6.Width = 104;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "Имя";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 3;
            this.columnHeader8.Text = "Фамилия";
            this.columnHeader8.Width = 118;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 4;
            this.columnHeader9.Text = "Отчество";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 5;
            this.columnHeader10.Text = "код";
            this.columnHeader10.Width = 57;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "номер телефона";
            this.columnHeader11.Width = 131;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "почта";
            this.columnHeader12.Width = 133;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(5, 145);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 47;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(5, 184);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 48;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(5, 223);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 20);
            this.tb_phone.TabIndex = 49;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(5, 262);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(100, 20);
            this.tb_mail.TabIndex = 50;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(5, 129);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(36, 13);
            this.label_login.TabIndex = 51;
            this.label_login.Text = "логин";
            this.label_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(2, 168);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(43, 13);
            this.label_password.TabIndex = 52;
            this.label_password.Text = "пароль";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(2, 207);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(91, 13);
            this.label_phone.TabIndex = 53;
            this.label_phone.Text = "номер телефона";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(2, 246);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(35, 13);
            this.label_mail.TabIndex = 54;
            this.label_mail.Text = "почта";
            // 
            // enteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 371);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ListViewTeachers);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.LabelPatronymic);
            this.Controls.Add(this.LabelSurname);
            this.Name = "enteacher";
            this.Text = "Учителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.ListView ListViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        internal System.Windows.Forms.Label LabelName;
        internal System.Windows.Forms.TextBox tb_name;
        internal System.Windows.Forms.TextBox tb_patronymic;
        internal System.Windows.Forms.TextBox tb_surname;
        internal System.Windows.Forms.Label LabelPatronymic;
        internal System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_mail;
    }
}