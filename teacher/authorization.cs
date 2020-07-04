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
    public partial class authorization : Form
    {
        public static int priv;
        public static int idteacher;
        public authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_vhod_Click(object sender, EventArgs e)
        {
            string type = cb_type.Text;
            if (type.Length < 8)
            {
               priv = 1; 
            }
            else
            {
                priv = 2;
            }
            
            if (tb_login.Text == "" && tb_password.Text == "")
            {
                MessageBox.Show("Вы не ввели данные!");
            }
            else
            {
                if (priv == 1)
                {
                    bool key = false;
                    foreach (teacher auth in Program.database.teacher)
                    {
                        if (tb_login.Text == auth.login && tb_password.Text == auth.password)
                        {
                            key = true;
                            idteacher = auth.Id;
                        }
                    }
                    if (!key)
                    {
                        MessageBox.Show("Данные введены неверно!");

                        tb_login.Text = "";
                        tb_password.Text = "";

                    }
                    else
                    {
                        menu menu = new menu();
                        menu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    bool key = false;
                    foreach (admin auth in Program.database.admin)
                    {
                        if (tb_login.Text == auth.login && tb_password.Text == auth.password)
                        {
                            key = true;
                        }
                    }
                    if (!key)
                    {
                        MessageBox.Show("Данные введены неверно!");

                        tb_login.Text = "";
                        tb_password.Text = "";

                    }
                    else
                    {
                        menu menu = new menu();
                        menu.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
