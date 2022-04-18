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
    public partial class formLogin : Form
    {
        CSDL_loginEntities db = new CSDL_loginEntities();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            main mains = new main();
            var result = from c in db.Logins where c.username == textbox_account.Text && c.passwordname==textBox_password.Text select c;
            if (textbox_account.Text==""||textBox_password.Text=="")
            {
                MessageBox.Show("not null account and password");
            }
            else
            {
                if (result.Count() == 1)
                {
                    mains.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login false");
                }
            }
           
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
