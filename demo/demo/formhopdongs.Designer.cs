
namespace demo
{
    partial class formhopdongs
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
            this.btn_backmain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backmain
            // 
            this.btn_backmain.Location = new System.Drawing.Point(25, 21);
            this.btn_backmain.Name = "btn_backmain";
            this.btn_backmain.Size = new System.Drawing.Size(84, 33);
            this.btn_backmain.TabIndex = 0;
            this.btn_backmain.Text = "Back";
            this.btn_backmain.UseVisualStyleBackColor = true;
            this.btn_backmain.Click += new System.EventHandler(this.btn_backmain_Click);
            // 
            // formhopdongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backmain);
            this.Name = "formhopdongs";
            this.Text = "formhopdongs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_backmain;
    }
}