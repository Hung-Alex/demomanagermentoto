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
    public partial class Customer : Form
    {
        dichvuchothuexeoto2Entities1 db = new dichvuchothuexeoto2Entities1();
        public Customer()
        {
            InitializeComponent();
            LoadDataCustomner();
        }
        void LoadDataCustomner()
        {
            gridview_customer.DataSource = db.khachhangs.ToList();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main backmain = new main();
            backmain.Show();
            this.Close();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            khachhang customers = new khachhang();
            Random rand = new Random();
            bool checkCodeKh = true;
            int codekh = rand.Next(0, 1000);
            try
            {
                while(checkCodeKh)
                {
                    var result = from c in db.khachhangs where c.makh == codekh.ToString() select c;
                    if (result.Count()==0)
                    {
                        checkCodeKh = false;
                    }
                    else
                    {
                        codekh = rand.Next(0, 1000);
                    }
                }
                customers.makh = codekh.ToString();
                customers.tenkh = textBox_namecustomer.Text.ToString();
                customers.cmnd = textBox_SCMND.Text.ToString();
                customers.sodt = textBox_PhoneNumber.Text.ToString();
                customers.diachi = textBox_address.Text.ToString();
                db.khachhangs.Add(customers);
                db.SaveChanges();
                LoadDataCustomner();
                MessageBox.Show("ADD Success");
            }
            catch (Exception)
            {

                MessageBox.Show("ADD NOT Success");
            }

        }

        private void btn_RemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                khachhang x = db.khachhangs.Where(item => item.makh == codemakh.Text.ToString() && item.tenkh==textBox_removename.Text.ToString()).SingleOrDefault();
                db.khachhangs.Remove(x);
                db.SaveChanges();
                LoadDataCustomner();
                MessageBox.Show("Remove success");
            }
            catch (Exception)
            {

                MessageBox.Show("Remove not success");
            }
          

        }
    }
}
