using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer customers = new Customer();
            customers.Show();
            this.Hide();
        }

        private void btn_oto_Click(object sender, EventArgs e)
        {
            Oto otos = new Oto();
            otos.Show();
            this.Hide();
        }

        private void btn_hopdong_Click(object sender, EventArgs e)
        {
            formhopdongs fhopdong = new formhopdongs();
            fhopdong.Show();
            this.Close();
            
        }
    }
}
