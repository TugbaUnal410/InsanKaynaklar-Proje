namespace InsankaynaklariProje
{
    partial class YoneticiIzinForm
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
            onaylaBtn = new Button();
            label1 = new Label();
            pidTxt = new TextBox();
            PersonelIzinTalepList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            istenilenGunTxt = new TextBox();
            aciklamaTxt = new TextBox();
            reddetBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // onaylaBtn
            // 
            onaylaBtn.Location = new Point(171, 315);
            onaylaBtn.Name = "onaylaBtn";
            onaylaBtn.Size = new Size(106, 29);
            onaylaBtn.TabIndex = 0;
            onaylaBtn.Text = "ONAYLA";
            onaylaBtn.UseVisualStyleBackColor = true;
            onaylaBtn.Click += onaylaBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 152);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "PERSONEL ID:";
            // 
            // pidTxt
            // 
            pidTxt.Location = new Point(245, 149);
            pidTxt.Name = "pidTxt";
            pidTxt.Size = new Size(140, 27);
            pidTxt.TabIndex = 2;
            pidTxt.TextChanged += textBox1_TextChanged;
            // 
            // PersonelIzinTalepList
            // 
            PersonelIzinTalepList.FormattingEnabled = true;
            PersonelIzinTalepList.Location = new Point(446, 139);
            PersonelIzinTalepList.Name = "PersonelIzinTalepList";
            PersonelIzinTalepList.Size = new Size(329, 144);
            PersonelIzinTalepList.TabIndex = 3;
            PersonelIzinTalepList.SelectedIndexChanged += PersonelızınTalepList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 212);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 4;
            label2.Text = "ISTENILEN GUN SAYISI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 263);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "ACIKLAMA:";
            // 
            // istenilenGunTxt
            // 
            istenilenGunTxt.Location = new Point(245, 209);
            istenilenGunTxt.Name = "istenilenGunTxt";
            istenilenGunTxt.Size = new Size(140, 27);
            istenilenGunTxt.TabIndex = 6;
            // 
            // aciklamaTxt
            // 
            aciklamaTxt.Location = new Point(245, 263);
            aciklamaTxt.Name = "aciklamaTxt";
            aciklamaTxt.Size = new Size(140, 27);
            aciklamaTxt.TabIndex = 7;
            // 
            // reddetBtn
            // 
            reddetBtn.Location = new Point(302, 315);
            reddetBtn.Name = "reddetBtn";
            reddetBtn.Size = new Size(106, 29);
            reddetBtn.TabIndex = 8;
            reddetBtn.Text = "REDDET";
            reddetBtn.UseVisualStyleBackColor = true;
            reddetBtn.Click += reddetBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(22, 35);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 9;
            label4.Text = "İZİN ONAY EKRANINDASINIZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(27, 74);
            label5.Name = "label5";
            label5.Size = new Size(322, 20);
            label5.TabIndex = 10;
            label5.Text = "Yapmak istediğiniz işlemi gerçekleştirebilirsiniz.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(onaylaBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(reddetBtn);
            panel1.Controls.Add(pidTxt);
            panel1.Controls.Add(aciklamaTxt);
            panel1.Controls.Add(PersonelIzinTalepList);
            panel1.Controls.Add(istenilenGunTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(300, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 395);
            panel1.TabIndex = 11;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(684, 356);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(106, 29);
            cıkısBtn.TabIndex = 12;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(552, 356);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(106, 29);
            anaMenuBtn.TabIndex = 11;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // YoneticiIzinForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 730);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "YoneticiIzinForm";
            Text = "YoneticiIzinForm";
            Load += YoneticiIzinForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button onaylaBtn;
        private Label label1;
        private TextBox pidTxt;
        private ListBox PersonelIzinTalepList;
        private Label label2;
        private Label label3;
        private TextBox istenilenGunTxt;
        private TextBox aciklamaTxt;
        private Button reddetBtn;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button anaMenuBtn;
        private Button cıkısBtn;
    }
}