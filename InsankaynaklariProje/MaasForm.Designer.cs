namespace InsankaynaklariProje
{
    partial class MaasForm
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
            pidTxt = new TextBox();
            brutTxt = new TextBox();
            bonusTxt = new TextBox();
            kesintiTxt = new TextBox();
            netTxt = new TextBox();
            ekleBtn = new Button();
            silBtn = new Button();
            guncelleTxt = new Button();
            MaasList = new ListBox();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaMenuBnt = new Button();
            odemeDate = new DateTimePicker();
            olusturmaDate = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 105);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "PERSONEL ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 150);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "BRUT MAAS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 199);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "BONUS MIKTARI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 246);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 3;
            label4.Text = "KESINTI MIKTARI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 288);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "NET MAAS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 337);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 5;
            label6.Text = "ODEME TARIHI:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 384);
            label7.Name = "label7";
            label7.Size = new Size(172, 20);
            label7.TabIndex = 6;
            label7.Text = "OLUSTURULAN TARIH:";
            // 
            // pidTxt
            // 
            pidTxt.Location = new Point(198, 98);
            pidTxt.Name = "pidTxt";
            pidTxt.Size = new Size(247, 27);
            pidTxt.TabIndex = 7;
            // 
            // brutTxt
            // 
            brutTxt.Location = new Point(198, 147);
            brutTxt.Name = "brutTxt";
            brutTxt.Size = new Size(247, 27);
            brutTxt.TabIndex = 8;
            // 
            // bonusTxt
            // 
            bonusTxt.Location = new Point(198, 196);
            bonusTxt.Name = "bonusTxt";
            bonusTxt.Size = new Size(247, 27);
            bonusTxt.TabIndex = 9;
            // 
            // kesintiTxt
            // 
            kesintiTxt.Location = new Point(198, 239);
            kesintiTxt.Name = "kesintiTxt";
            kesintiTxt.Size = new Size(247, 27);
            kesintiTxt.TabIndex = 10;
            // 
            // netTxt
            // 
            netTxt.Location = new Point(198, 281);
            netTxt.Name = "netTxt";
            netTxt.Size = new Size(247, 27);
            netTxt.TabIndex = 11;
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(77, 450);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(106, 29);
            ekleBtn.TabIndex = 14;
            ekleBtn.Text = "EKLE";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(221, 450);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(106, 29);
            silBtn.TabIndex = 15;
            silBtn.Text = "SIL";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // guncelleTxt
            // 
            guncelleTxt.Location = new Point(357, 450);
            guncelleTxt.Name = "guncelleTxt";
            guncelleTxt.Size = new Size(106, 29);
            guncelleTxt.TabIndex = 16;
            guncelleTxt.Text = "GUNCELLE";
            guncelleTxt.UseVisualStyleBackColor = true;
            guncelleTxt.Click += guncelleTxt_Click;
            // 
            // MaasList
            // 
            MaasList.FormattingEnabled = true;
            MaasList.Location = new Point(452, 95);
            MaasList.Name = "MaasList";
            MaasList.Size = new Size(349, 324);
            MaasList.TabIndex = 17;
            MaasList.SelectedIndexChanged += MaasList_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(16, 13);
            label8.Name = "label8";
            label8.Size = new Size(232, 25);
            label8.TabIndex = 18;
            label8.Text = "MAAŞ EKRANINDASINIZ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(21, 38);
            label9.Name = "label9";
            label9.Size = new Size(340, 20);
            label9.TabIndex = 19;
            label9.Text = "Yapmak istediğiniz işlemi gerçekleşleştirebilirsiniz.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(olusturmaDate);
            panel1.Controls.Add(odemeDate);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBnt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MaasList);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guncelleTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(silBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ekleBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pidTxt);
            panel1.Controls.Add(netTxt);
            panel1.Controls.Add(brutTxt);
            panel1.Controls.Add(kesintiTxt);
            panel1.Controls.Add(bonusTxt);
            panel1.Location = new Point(245, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 525);
            panel1.TabIndex = 20;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(742, 493);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(106, 29);
            cıkısBtn.TabIndex = 21;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBnt
            // 
            anaMenuBnt.Location = new Point(630, 493);
            anaMenuBnt.Name = "anaMenuBnt";
            anaMenuBnt.Size = new Size(106, 29);
            anaMenuBnt.TabIndex = 20;
            anaMenuBnt.Text = "ANA MENU";
            anaMenuBnt.UseVisualStyleBackColor = true;
            anaMenuBnt.Click += anaMenuBnt_Click;
            // 
            // odemeDate
            // 
            odemeDate.Location = new Point(195, 338);
            odemeDate.Name = "odemeDate";
            odemeDate.Size = new Size(250, 27);
            odemeDate.TabIndex = 22;
            // 
            // olusturmaDate
            // 
            olusturmaDate.Location = new Point(196, 385);
            olusturmaDate.Name = "olusturmaDate";
            olusturmaDate.Size = new Size(250, 27);
            olusturmaDate.TabIndex = 23;
            // 
            // MaasForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1316, 730);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MaasForm";
            Text = "MaasForm";
            Load += MaasForm_Load;
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
        private TextBox pidTxt;
        private TextBox brutTxt;
        private TextBox bonusTxt;
        private TextBox kesintiTxt;
        private TextBox netTxt;
        private Button ekleBtn;
        private Button silBtn;
        private Button guncelleTxt;
        private ListBox MaasList;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Button anaMenuBnt;
        private Button cıkısBtn;
        private DateTimePicker odemeDate;
        private DateTimePicker olusturmaDate;
    }
}