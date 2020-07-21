using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Shop
{
    public partial class frm_DNhap : Form
    {
        public frm_DNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = null;
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Text = null;
        }





    }
}
