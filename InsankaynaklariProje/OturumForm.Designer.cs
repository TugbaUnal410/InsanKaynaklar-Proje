namespace InsankaynaklariProje
{
    partial class OturumForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturumForm));
            panel1 = new Panel();
            girisBtn = new Button();
            sifreTxt = new TextBox();
            kullaniciAdTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(girisBtn);
            panel1.Controls.Add(sifreTxt);
            panel1.Controls.Add(kullaniciAdTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(354, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 222);
            panel1.TabIndex = 0;
            // 
            // girisBtn
            // 
            girisBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            girisBtn.Location = new Point(90, 144);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(94, 29);
            girisBtn.TabIndex = 4;
            girisBtn.Text = "GIRIS YAP";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += girisBtn_Click;
            // 
            // sifreTxt
            // 
            sifreTxt.Location = new Point(109, 88);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.Size = new Size(125, 27);
            sifreTxt.TabIndex = 3;
            // 
            // kullaniciAdTxt
            // 
            kullaniciAdTxt.Location = new Point(109, 29);
            kullaniciAdTxt.Name = "kullaniciAdTxt";
            kullaniciAdTxt.Size = new Size(125, 27);
            kullaniciAdTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(58, 88);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Sifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 36);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanici Adi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(354, 54);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 1;
            label3.Text = "PERSONEL GİRİŞİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(354, 108);
            label4.Name = "label4";
            label4.Size = new Size(204, 20);
            label4.TabIndex = 2;
            label4.Text = "Lutfen sisteme giriş yapınız.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 457);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 259);
            label6.Name = "label6";
            label6.Size = new Size(239, 20);
            label6.TabIndex = 5;
            label6.Text = "HIZLI-GÜVENİLİR-ULAŞILABİLİR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 195);
            label5.Name = "label5";
            label5.Size = new Size(218, 32);
            label5.TabIndex = 4;
            label5.Text = "NOVİVA LOGISTIC";
            // 
            // OturumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 451);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "OturumForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button girisBtn;
        private TextBox sifreTxt;
        private TextBox kullaniciAdTxt;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
