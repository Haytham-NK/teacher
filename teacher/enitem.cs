using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class enitem : Form
    {
        public enitem()
        {
            InitializeComponent();
        }

        void ShowTeachercs()
        {
            ListViewitem.Items.Clear();
            foreach (item item in Program.database.item)
            {
                ListViewItem it = new ListViewItem(new string[]
                {
                item.Name, item.Idteach.ToString()
                });
                it.Tag = item;
                ListViewitem.Items.Add(it);
            }
            ListViewitem.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void cb_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacher teach = new teacher();
            cb_teacher.DataSource = teach;
            cb_teacher.DisplayMember = "2";
            cb_teacher.ValueMember = "Id";
            cb_teacher.SelectedIndex = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            item items = new item();
            items.Name = tb_item.Text;
            items.Idteach = Convert.ToInt32(cb_teacher.Text);
            Program.database.item.Add(items);
            Program.database.SaveChanges();
            ShowTeachercs();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ListViewitem.SelectedItems.Count == 1)
            {
                item items = ListViewitem.SelectedItems[0].Tag as item;
                items.Name = tb_item.Text;
                items.Idteach = Convert.ToInt32(cb_teacher.Text);
                Program.database.SaveChanges();
                ShowTeachercs();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewitem.SelectedItems.Count == 1)
                {
                    item del = ListViewitem.SelectedItems[0].Tag as item;
                    Program.database.item.Remove(del);
                    Program.database.SaveChanges();
                }
                tb_item.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить запись!");
            }
            Program.database.SaveChanges();
            ShowTeachercs();
        }

        private void ListViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
