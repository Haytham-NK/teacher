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
    public partial class lkteach : Form
    {
        public static int id;
        public lkteach()
        {
            int id = Convert.ToInt32(authorization.idteacher);
            InitializeComponent();
        }

private void ListViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

