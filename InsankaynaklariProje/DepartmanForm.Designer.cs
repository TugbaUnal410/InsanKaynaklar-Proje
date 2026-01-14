namespace InsankaynaklariProje
{
    partial class DepartmanForm
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
            adTxt = new TextBox();
            ekleBtn = new Button();
            DepartmanList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            katTxt = new TextBox();
            iletisimTxt = new TextBox();
            silBtn = new Button();
            guncelleBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            date = new DateTimePicker();
            cıkısBtn = new Button();
            anaBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 97);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "DEPARTMAN ADI:";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(227, 90);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(233, 27);
            adTxt.TabIndex = 1;
            // 
            // ekleBtn
            // 
            ekleBtn.Location = new Point(64, 280);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(123, 30);
            ekleBtn.TabIndex = 2;
            ekleBtn.Text = "EKLE";
            ekleBtn.UseVisualStyleBackColor = true;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // DepartmanList
            // 
            DepartmanList.FormattingEnabled = true;
            DepartmanList.Location = new Point(487, 90);
            DepartmanList.Name = "DepartmanList";
            DepartmanList.Size = new Size(396, 164);
            DepartmanList.TabIndex = 3;
            DepartmanList.SelectedIndexChanged += DepartmanList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 140);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 4;
            label2.Text = "DEPARTMAN KATI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 185);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 5;
            label3.Text = "DEPARTMAN ILETISIM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 235);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 6;
            label4.Text = "OLUSTURULAN TARİH:";
            // 
            // katTxt
            // 
            katTxt.Location = new Point(227, 137);
            katTxt.Name = "katTxt";
            katTxt.Size = new Size(233, 27);
            katTxt.TabIndex = 7;
            // 
            // iletisimTxt
            // 
            iletisimTxt.Location = new Point(227, 182);
            iletisimTxt.Name = "iletisimTxt";
            iletisimTxt.Size = new Size(233, 27);
            iletisimTxt.TabIndex = 8;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(226, 280);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(109, 30);
            silBtn.TabIndex = 10;
            silBtn.Text = "SIL";
            silBtn.UseVisualStyleBackColor = true;
            silBtn.Click += silBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Location = new Point(378, 280);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(137, 30);
            guncelleBtn.TabIndex = 11;
            guncelleBtn.Text = "GUNCELLE";
            guncelleBtn.UseVisualStyleBackColor = true;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(36, 13);
            label5.Name = "label5";
            label5.Size = new Size(299, 25);
            label5.TabIndex = 12;
            label5.Text = "DEPARTMAN EKRANINDASINIZ ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(37, 38);
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
            panel1.Controls.Add(anaBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(adTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DepartmanList);
            panel1.Controls.Add(guncelleBtn);
            panel1.Controls.Add(katTxt);
            panel1.Controls.Add(silBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ekleBtn);
            panel1.Controls.Add(iletisimTxt);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(224, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 368);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // date
            // 
            date.Location = new Point(227, 230);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 16;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(781, 326);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(137, 30);
            cıkısBtn.TabIndex = 15;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaBtn
            // 
            anaBtn.Location = new Point(613, 326);
            anaBtn.Name = "anaBtn";
            anaBtn.Size = new Size(137, 30);
            anaBtn.TabIndex = 14;
            anaBtn.Text = "ANA MENU";
            anaBtn.UseVisualStyleBackColor = true;
            anaBtn.Click += anaBtn_Click;
            // 
            // DepartmanForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1369, 776);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "DepartmanForm";
            Text = "DepartmanForm";
            Load += DepartmanForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox adTxt;
        private Button ekleBtn;
        private ListBox DepartmanList;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox katTxt;
        private TextBox iletisimTxt;
        private Button silBtn;
        private Button guncelleBtn;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Button cıkısBtn;
        private Button anaBtn;
        private DateTimePicker date;
    }
}