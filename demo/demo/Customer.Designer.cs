
namespace demo
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.gridview_customer = new System.Windows.Forms.DataGridView();
            this.textBox_namecustomer = new System.Windows.Forms.TextBox();
            this.textBox_SCMND = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_namecustomer = new System.Windows.Forms.Label();
            this.label_scmnd = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_RemoveCustomer = new System.Windows.Forms.Button();
            this.btn_EditCustomer = new System.Windows.Forms.Button();
            this.codemakh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_removename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(-5, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // gridview_customer
            // 
            this.gridview_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_customer.Location = new System.Drawing.Point(12, 307);
            this.gridview_customer.Name = "gridview_customer";
            this.gridview_customer.RowHeadersWidth = 51;
            this.gridview_customer.RowTemplate.Height = 24;
            this.gridview_customer.Size = new System.Drawing.Size(1240, 179);
            this.gridview_customer.TabIndex = 1;
            // 
            // textBox_namecustomer
            // 
            this.textBox_namecustomer.Location = new System.Drawing.Point(350, 56);
            this.textBox_namecustomer.Name = "textBox_namecustomer";
            this.textBox_namecustomer.Size = new System.Drawing.Size(297, 22);
            this.textBox_namecustomer.TabIndex = 2;
            // 
            // textBox_SCMND
            // 
            this.textBox_SCMND.Location = new System.Drawing.Point(350, 104);
            this.textBox_SCMND.Name = "textBox_SCMND";
            this.textBox_SCMND.Size = new System.Drawing.Size(322, 22);
            this.textBox_SCMND.TabIndex = 3;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(350, 145);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(392, 22);
            this.textBox_address.TabIndex = 4;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(350, 194);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(276, 22);
            this.textBox_PhoneNumber.TabIndex = 5;
            // 
            // label_namecustomer
            // 
            this.label_namecustomer.AutoSize = true;
            this.label_namecustomer.Location = new System.Drawing.Point(149, 56);
            this.label_namecustomer.Name = "label_namecustomer";
            this.label_namecustomer.Size = new System.Drawing.Size(115, 17);
            this.label_namecustomer.TabIndex = 6;
            this.label_namecustomer.Text = "Tên Khách Hàng";
            // 
            // label_scmnd
            // 
            this.label_scmnd.AutoSize = true;
            this.label_scmnd.Location = new System.Drawing.Point(149, 107);
            this.label_scmnd.Name = "label_scmnd";
            this.label_scmnd.Size = new System.Drawing.Size(172, 17);
            this.label_scmnd.TabIndex = 7;
            this.label_scmnd.Text = "Số Chứng Mình Nhân Dân";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(149, 150);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(53, 17);
            this.label_address.TabIndex = 8;
            this.label_address.Text = "Địa Chỉ";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Location = new System.Drawing.Point(149, 199);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(98, 17);
            this.label_phonenumber.TabIndex = 9;
            this.label_phonenumber.Text = "Số Điện Thoại";
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(152, 253);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(151, 38);
            this.btn_addCustomer.TabIndex = 10;
            this.btn_addCustomer.Text = "Thêm";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_RemoveCustomer
            // 
            this.btn_RemoveCustomer.Location = new System.Drawing.Point(374, 253);
            this.btn_RemoveCustomer.Name = "btn_RemoveCustomer";
            this.btn_RemoveCustomer.Size = new System.Drawing.Size(151, 38);
            this.btn_RemoveCustomer.TabIndex = 11;
            this.btn_RemoveCustomer.Text = "Xóa";
            this.btn_RemoveCustomer.UseVisualStyleBackColor = true;
            this.btn_RemoveCustomer.Click += new System.EventHandler(this.btn_RemoveCustomer_Click);
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.Location = new System.Drawing.Point(591, 253);
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Size = new System.Drawing.Size(151, 38);
            this.btn_EditCustomer.TabIndex = 12;
            this.btn_EditCustomer.Text = "Chỉnh Sửa";
            this.btn_EditCustomer.UseVisualStyleBackColor = true;
            // 
            // codemakh
            // 
            this.codemakh.Location = new System.Drawing.Point(948, 171);
            this.codemakh.Name = "codemakh";
            this.codemakh.Size = new System.Drawing.Size(145, 22);
            this.codemakh.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập Mã  Xóa";
            // 
            // textBox_removename
            // 
            this.textBox_removename.Location = new System.Drawing.Point(948, 212);
            this.textBox_removename.Name = "textBox_removename";
            this.textBox_removename.Size = new System.Drawing.Size(145, 22);
            this.textBox_removename.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập Tên Muốn Xóa";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_removename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codemakh);
            this.Controls.Add(this.btn_EditCustomer);
            this.Controls.Add(this.btn_RemoveCustomer);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.label_phonenumber);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_scmnd);
            this.Controls.Add(this.label_namecustomer);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_SCMND);
            this.Controls.Add(this.textBox_namecustomer);
            this.Controls.Add(this.gridview_customer);
            this.Controls.Add(this.btn_back);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView gridview_customer;
        private System.Windows.Forms.TextBox textBox_namecustomer;
        private System.Windows.Forms.TextBox textBox_SCMND;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_namecustomer;
        private System.Windows.Forms.Label label_scmnd;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_RemoveCustomer;
        private System.Windows.Forms.Button btn_EditCustomer;
        private System.Windows.Forms.TextBox codemakh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_removename;
        private System.Windows.Forms.Label label2;
    }
}