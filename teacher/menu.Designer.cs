namespace teacher
{
    partial class menu
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
            this.bt_teach = new System.Windows.Forms.Button();
            this.bt_item = new System.Windows.Forms.Button();
            this.tb_teach_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_teach
            // 
            this.bt_teach.Location = new System.Drawing.Point(50, 26);
            this.bt_teach.Name = "bt_teach";
            this.bt_teach.Size = new System.Drawing.Size(89, 38);
            this.bt_teach.TabIndex = 0;
            this.bt_teach.Text = "Учителя";
            this.bt_teach.UseVisualStyleBackColor = true;
            this.bt_teach.Click += new System.EventHandler(this.bt_teach_Click);
            // 
            // bt_item
            // 
            this.bt_item.Location = new System.Drawing.Point(50, 98);
            this.bt_item.Name = "bt_item";
            this.bt_item.Size = new System.Drawing.Size(89, 38);
            this.bt_item.TabIndex = 1;
            this.bt_item.Text = "Предметы";
            this.bt_item.UseVisualStyleBackColor = true;
            this.bt_item.Click += new System.EventHandler(this.bt_item_Click);
            // 
            // tb_teach_item
            // 
            this.tb_teach_item.Location = new System.Drawing.Point(50, 173);
            this.tb_teach_item.Name = "tb_teach_item";
            this.tb_teach_item.Size = new System.Drawing.Size(89, 38);
            this.tb_teach_item.TabIndex = 2;
            this.tb_teach_item.Text = "Кабинет Учителя";
            this.tb_teach_item.UseVisualStyleBackColor = true;
            this.tb_teach_item.Click += new System.EventHandler(this.tb_teach_item_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 272);
            this.Controls.Add(this.tb_teach_item);
            this.Controls.Add(this.bt_item);
            this.Controls.Add(this.bt_teach);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_teach;
        private System.Windows.Forms.Button bt_item;
        private System.Windows.Forms.Button tb_teach_item;
    }
}