namespace InsankaynaklariProje
{
    partial class PerformansForm
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
            ekleBtn = new Button();
            silBtn = new Button();
            guncelleBtn = new Button();
            pidTxt = new TextBox();
            puanTxt = new TextBox();
            donemTxt = new TextBox();
            PerformansList = new ListBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            date = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 118);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "PERSONEL ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 162);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "PUAN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 206);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 2;
            label3.Text = "OLUSTURMA TARIHI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 251);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 3;
            label4.Text = "DEGERLENDIRME DONEMI:";
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(97, 302);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(106, 29);
            ekleBtn.TabIndex = 4;
            ekleBtn.Text = "EKLE";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(244, 302);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(106, 29);
            silBtn.TabIndex = 5;
            silBtn.Text = "SIL";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Location = new Point(405, 302);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(106, 29);
            guncelleBtn.TabIndex = 6;
            guncelleBtn.Text = "GUNCELLE";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // pidTxt
            // 
            pidTxt.Location = new Point(229, 115);
            pidTxt.Name = "pidTxt";
            pidTxt.Size = new Size(232, 27);
            pidTxt.TabIndex = 7;
            // 
            // puanTxt
            // 
            puanTxt.Location = new Point(229, 159);
            puanTxt.Name = "puanTxt";
            puanTxt.Size = new Size(232, 27);
            puanTxt.TabIndex = 8;
            // 
            // donemTxt
            // 
            donemTxt.Location = new Point(229, 248);
            donemTxt.Name = "donemTxt";
            donemTxt.Size = new Size(232, 27);
            donemTxt.TabIndex = 10;
            // 
            // PerformansList
            // 
            PerformansList.FormattingEnabled = true;
            PerformansList.Location = new Point(509, 118);
            PerformansList.Name = "PerformansList";
            PerformansList.Size = new Size(316, 164);
            PerformansList.TabIndex = 11;
            PerformansList.SelectedIndexChanged += PerformansList_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(20, 21);
            label5.Name = "label5";
            label5.Size = new Size(304, 25);
            label5.TabIndex = 12;
            label5.Text = "PERFORMANS EKRANINDASINIZ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(20, 58);
            label6.Name = "label6";
            label6.Size = new Size(340, 20);
            label6.TabIndex = 13;
            label6.Text = "Yapmak istediğiniz işlemi gerçekleşleştirebilirsiniz.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(date);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PerformansList);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(donemTxt);
            panel1.Controls.Add(ekleBtn);
            panel1.Controls.Add(silBtn);
            panel1.Controls.Add(puanTxt);
            panel1.Controls.Add(guncelleBtn);
            panel1.Controls.Add(pidTxt);
            panel1.Location = new Point(231, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 434);
            panel1.TabIndex = 14;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(719, 402);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(106, 29);
            cıkısBtn.TabIndex = 15;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(607, 402);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(106, 29);
            anaMenuBtn.TabIndex = 14;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // date
            // 
            date.Location = new Point(215, 201);
            date.Name = "date";
            date.Size = new Size(246, 27);
            date.TabIndex = 16;
            // 
            // PerformansForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1390, 759);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "PerformansForm";
            Text = "PerformansForm";
            Load += PerformansForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ekleBtn;
        private Button silBtn;
        private Button guncelleBtn;
        private TextBox pidTxt;
        private TextBox puanTxt;
        private TextBox donemTxt;
        private ListBox PerformansList;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Button anaMenuBtn;
        private Button cıkısBtn;
        private DateTimePicker date;
    }
}