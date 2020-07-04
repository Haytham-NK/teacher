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
    public partial class enteacher : Form
    {
        public enteacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void ShowTeachercs()
        {
            ListViewTeachers.Items.Clear();
            foreach (teacher add in Program.database.teacher)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                add.Id.ToString(), add.login, add.password, add.Name, add.Surname,
                add.Patronymic,  add.Phone, add.Mail
                });
                item.Tag = add;
                ListViewTeachers.Items.Add(item);
            }
            ListViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            teacher add = new teacher();
            add.Surname = tb_surname.Text;
            add.Name = tb_name.Text;
            add.Patronymic = tb_patronymic.Text;
            add.login = tb_login.Text;
            add.password = tb_password.Text;
            add.Phone = tb_phone.Text;
            add.Mail = tb_mail.Text;
            Program.database.teacher.Add(add);
            Program.database.SaveChanges();
            ShowTeachercs();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ListViewTeachers.SelectedItems.Count == 1)
            {
                teacher edit = ListViewTeachers.SelectedItems[0].Tag as teacher;
                edit.Surname = tb_surname.Text;
                edit.Name = tb_name.Text;
                edit.Patronymic = tb_patronymic.Text;
                edit.login = tb_login.Text;
                edit.password = tb_password.Text;
                edit.Phone = tb_phone.Text;
                edit.Mail = tb_mail.Text;
                Program.database.SaveChanges();
                ShowTeachercs();
            }
            
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewTeachers.SelectedItems.Count == 1)
                {
                    teacher edit = ListViewTeachers.SelectedItems[0].Tag as teacher;
                    Program.database.teacher.Remove(edit);
                    Program.database.SaveChanges();
                }
                tb_surname.Text = "";
                tb_name.Text = "";
                tb_patronymic.Text = "";
                tb_login.Text = "";
                tb_password.Text = "";
                tb_phone.Text = "";
                tb_mail.Text = "";
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
