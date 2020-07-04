namespace teacher
{
    partial class enitem
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
            this.ListViewitem = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_teacher = new System.Windows.Forms.ComboBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.Label_teacher = new System.Windows.Forms.Label();
            this.Label_item = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(652, 342);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 56;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(571, 342);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 55;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(490, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Создать";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ListViewitem
            // 
            this.ListViewitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.ColumnHeader1});
            this.ListViewitem.HideSelection = false;
            this.ListViewitem.Location = new System.Drawing.Point(143, 12);
            this.ListViewitem.Name = "ListViewitem";
            this.ListViewitem.Size = new System.Drawing.Size(581, 324);
            this.ListViewitem.TabIndex = 49;
            this.ListViewitem.UseCompatibleStateImageBehavior = false;
            this.ListViewitem.View = System.Windows.Forms.View.Details;
            this.ListViewitem.SelectedIndexChanged += new System.EventHandler(this.ListViewTeachers_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "предмет";
            this.ColumnHeader.Width = 124;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "учитель";
            this.ColumnHeader1.Width = 158;
            // 
            // cb_teacher
            // 
            this.cb_teacher.FormattingEnabled = true;
            this.cb_teacher.Location = new System.Drawing.Point(9, 67);
            this.cb_teacher.Name = "cb_teacher";
            this.cb_teacher.Size = new System.Drawing.Size(100, 21);
            this.cb_teacher.TabIndex = 58;
            this.cb_teacher.SelectedIndexChanged += new System.EventHandler(this.cb_teacher_SelectedIndexChanged);
            // 
            // tb_item
            // 
            this.tb_item.Location = new System.Drawing.Point(9, 28);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(100, 20);
            this.tb_item.TabIndex = 50;
            // 
            // Label_teacher
            // 
            this.Label_teacher.AutoSize = true;
            this.Label_teacher.Location = new System.Drawing.Point(9, 51);
            this.Label_teacher.Name = "Label_teacher";
            this.Label_teacher.Size = new System.Drawing.Size(49, 13);
            this.Label_teacher.TabIndex = 53;
            this.Label_teacher.Text = "Учитель";
            // 
            // Label_item
            // 
            this.Label_item.AutoSize = true;
            this.Label_item.Location = new System.Drawing.Point(9, 12);
            this.Label_item.Name = "Label_item";
            this.Label_item.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_item.Size = new System.Drawing.Size(52, 13);
            this.Label_item.TabIndex = 51;
            this.Label_item.Text = "Предмет";
            // 
            // enitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 373);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ListViewitem);
            this.Controls.Add(this.cb_teacher);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.Label_teacher);
            this.Controls.Add(this.Label_item);
            this.Name = "enitem";
            this.Text = "Предметы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.ListView ListViewitem;
        internal System.Windows.Forms.ColumnHeader ColumnHeader;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ComboBox cb_teacher;
        internal System.Windows.Forms.TextBox tb_item;
        internal System.Windows.Forms.Label Label_teacher;
        internal System.Windows.Forms.Label Label_item;
    }
}