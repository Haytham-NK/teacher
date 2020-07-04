using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class menu : Form
    {
        int id = Convert.ToInt32(authorization.priv);
        public menu()
        {
            InitializeComponent();
            if(id == 1)
            {
                bt_teach.Enabled = false;
                bt_item.Enabled = false;
            }
            else
            {
                tb_teach_item.Enabled = false;
            }
        }
           
        private void bt_teach_Click(object sender, EventArgs e)
        {
            enteacher teach = new enteacher();
            teach.Show();
            this.Hide();
        }

        private void bt_item_Click(object sender, EventArgs e)
        {
            enitem items = new enitem();
            items.Show();
            this.Hide();
        }

        private void tb_teach_item_Click(object sender, EventArgs e)
        {
             lkteach lk= new lkteach();
            lk.Show();
            this.Hide();
        }
    }
}
