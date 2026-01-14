namespace InsankaynaklariProje
{
    partial class PersonelForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            didComboBox = new ComboBox();
            adTxt = new TextBox();
            soyadTxt = new TextBox();
            pozisyonTxt = new TextBox();
            telTxt = new TextBox();
            epostaTxt = new TextBox();
            PersonelList = new ListBox();
            ekleBtn = new Button();
            silBtn = new Button();
            guncelleBtn = new Button();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            olusturmaDate = new DateTimePicker();
            baslangicDate = new DateTimePicker();
            cıkısBtn = new Button();
            anaBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 110);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 161);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 204);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "DEPARTMAN ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 248);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "POZİSYON:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 348);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "TEL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 392);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 5;
            label6.Text = "EPOSTA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 302);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 6;
            label7.Text = "BASLANGIC TARIHI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 431);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 7;
            label8.Text = "OLUSTURMA TARIHI:";
            // 
            // didComboBox
            // 
            didComboBox.FormattingEnabled = true;
            didComboBox.Location = new Point(193, 201);
            didComboBox.Name = "didComboBox";
            didComboBox.Size = new Size(247, 28);
            didComboBox.TabIndex = 8;
            // 
            // adTxt
            // 
            adTxt.Location = new Point(194, 107);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(246, 27);
            adTxt.TabIndex = 9;
            // 
            // soyadTxt
            // 
            soyadTxt.Location = new Point(193, 154);
            soyadTxt.Name = "soyadTxt";
            soyadTxt.Size = new Size(247, 27);
            soyadTxt.TabIndex = 10;
            // 
            // pozisyonTxt
            // 
            pozisyonTxt.Location = new Point(193, 241);
            pozisyonTxt.Name = "pozisyonTxt";
            pozisyonTxt.Size = new Size(247, 27);
            pozisyonTxt.TabIndex = 11;
            // 
            // telTxt
            // 
            telTxt.Location = new Point(193, 341);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(247, 27);
            telTxt.TabIndex = 13;
            // 
            // epostaTxt
            // 
            epostaTxt.Location = new Point(193, 385);
            epostaTxt.Name = "epostaTxt";
            epostaTxt.Size = new Size(247, 27);
            epostaTxt.TabIndex = 14;
            // 
            // PersonelList
            // 
            PersonelList.FormattingEnabled = true;
            PersonelList.Location = new Point(458, 107);
            PersonelList.Name = "PersonelList";
            PersonelList.Size = new Size(477, 344);
            PersonelList.TabIndex = 16;
            PersonelList.SelectedIndexChanged += PersonelList_SelectedIndexChanged;
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(70, 487);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(106, 29);
            ekleBtn.TabIndex = 17;
            ekleBtn.Text = "EKLE";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(203, 487);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(106, 29);
            silBtn.TabIndex = 18;
            silBtn.Text = "SIL";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Location = new Point(348, 487);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(106, 29);
            guncelleBtn.TabIndex = 19;
            guncelleBtn.Text = "GUNCELLE";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(20, 20);
            label9.Name = "label9";
            label9.Size = new Size(271, 25);
            label9.TabIndex = 20;
            label9.Text = "PERSONEL EKRANINDASINIZ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(20, 61);
            label10.Name = "label10";
            label10.Size = new Size(340, 20);
            label10.TabIndex = 21;
            label10.Text = "Yapmak istediğiniz işlemi gerçekleşleştirebilirsiniz.";
            // 
            // panel1
            // 
            panel1.Controls.Add(olusturmaDate);
            panel1.Controls.Add(baslangicDate);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaBtn);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guncelleBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(silBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ekleBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PersonelList);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(epostaTxt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(telTxt);
            panel1.Controls.Add(didComboBox);
            panel1.Controls.Add(adTxt);
            panel1.Controls.Add(pozisyonTxt);
            panel1.Controls.Add(soyadTxt);
            panel1.Location = new Point(226, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 552);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // olusturmaDate
            // 
            olusturmaDate.Location = new Point(190, 424);
            olusturmaDate.Name = "olusturmaDate";
            olusturmaDate.Size = new Size(250, 27);
            olusturmaDate.TabIndex = 25;
            // 
            // baslangicDate
            // 
            baslangicDate.Location = new Point(191, 300);
            baslangicDate.Name = "baslangicDate";
            baslangicDate.Size = new Size(250, 27);
            baslangicDate.TabIndex = 24;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(764, 520);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(106, 29);
            cıkısBtn.TabIndex = 23;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaBtn
            // 
            anaBtn.Location = new Point(636, 520);
            anaBtn.Name = "anaBtn";
            anaBtn.Size = new Size(106, 29);
            anaBtn.TabIndex = 22;
            anaBtn.Text = "ANA MENU";
            anaBtn.UseVisualStyleBackColor = true;
            anaBtn.Click += anaBtn_Click;
            // 
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1330, 763);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "PersonelForm";
            Text = "PersonelForm";
            Load += PersonelForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox didComboBox;
        private TextBox adTxt;
        private TextBox soyadTxt;
        private TextBox pozisyonTxt;
        private TextBox telTxt;
        private TextBox epostaTxt;
        private ListBox PersonelList;
        private Button ekleBtn;
        private Button silBtn;
        private Button guncelleBtn;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Button cıkısBtn;
        private Button anaBtn;
        private DateTimePicker olusturmaDate;
        private DateTimePicker baslangicDate;
    }
}