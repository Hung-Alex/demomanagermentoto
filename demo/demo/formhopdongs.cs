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
    public partial class formhopdongs : Form
    {
        public formhopdongs()
        {
            InitializeComponent();
        }

        private void btn_backmain_Click(object sender, EventArgs e)
        {
            main mains = new main();
            mains.Show();
            this.Close();
        }
    }
}
