namespace teacher
{
    partial class lkteach
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
            this.ListViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.ListViewTeachers.Location = new System.Drawing.Point(12, 12);
            this.ListViewTeachers.Name = "ListViewTeachers";
            this.ListViewTeachers.Size = new System.Drawing.Size(671, 338);
            this.ListViewTeachers.TabIndex = 37;
            this.ListViewTeachers.UseCompatibleStateImageBehavior = false;
            this.ListViewTeachers.View = System.Windows.Forms.View.Details;
            this.ListViewTeachers.SelectedIndexChanged += new System.EventHandler(this.ListViewTeachers_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 5;
            this.columnHeader10.Text = "код";
            this.columnHeader10.Width = 57;
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
            // lkteach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 357);
            this.Controls.Add(this.ListViewTeachers);
            this.Name = "lkteach";
            this.Text = "lkteach";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView ListViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}