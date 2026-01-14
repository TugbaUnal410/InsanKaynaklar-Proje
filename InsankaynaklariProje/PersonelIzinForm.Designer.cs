namespace InsankaynaklariProje
{
    partial class PersonelIzinForm
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
            talepBtn = new Button();
            IzinList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            istenilenGunTxt = new TextBox();
            aciklamaTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // talepBtn
            // 
            talepBtn.Location = new Point(89, 179);
            talepBtn.Name = "talepBtn";
            talepBtn.Size = new Size(232, 29);
            talepBtn.TabIndex = 0;
            talepBtn.Text = "IZIN TALEBI GONDER";
            talepBtn.UseVisualStyleBackColor = true;
            talepBtn.Click += talepBtn_Click;
            // 
            // IzinList
            // 
            IzinList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            IzinList.FormattingEnabled = true;
            IzinList.Location = new Point(412, 44);
            IzinList.Name = "IzinList";
            IzinList.Size = new Size(391, 164);
            IzinList.TabIndex = 3;
            IzinList.SelectedIndexChanged += IzinList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 4;
            label2.Text = "ISTENILEN GUN SAYISI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 129);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "ACIKLAMA:";
            // 
            // istenilenGunTxt
            // 
            istenilenGunTxt.Location = new Point(205, 83);
            istenilenGunTxt.Name = "istenilenGunTxt";
            istenilenGunTxt.Size = new Size(140, 27);
            istenilenGunTxt.TabIndex = 6;
            // 
            // aciklamaTxt
            // 
            aciklamaTxt.Location = new Point(205, 122);
            aciklamaTxt.Name = "aciklamaTxt";
            aciklamaTxt.Size = new Size(140, 27);
            aciklamaTxt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(14, 15);
            label4.Name = "label4";
            label4.Size = new Size(276, 25);
            label4.TabIndex = 8;
            label4.Text = "İZİN TALEP EKRANINDASINIZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(24, 40);
            label5.Name = "label5";
            label5.Size = new Size(206, 20);
            label5.TabIndex = 9;
            label5.Text = "İzin talebinde bulunabilirsiniz.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(IzinList);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(talepBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(aciklamaTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(istenilenGunTxt);
            panel1.Location = new Point(246, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 304);
            panel1.TabIndex = 10;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(712, 258);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(134, 29);
            cıkısBtn.TabIndex = 11;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(544, 258);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(148, 29);
            anaMenuBtn.TabIndex = 10;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // PersonelIzinForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 757);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "PersonelIzinForm";
            Text = "PersonelIzinForm";
            Load += PersonelIzinForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button talepBtn;
        private ListBox IzinList;
        private Label label2;
        private Label label3;
        private TextBox istenilenGunTxt;
        private TextBox aciklamaTxt;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button cıkısBtn;
        private Button anaMenuBtn;
    }
}