namespace InsankaynaklariProje
{
    partial class EnYuksekMaasAlanBesPersonel
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
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            raporBtn = new Button();
            label3 = new Label();
            yilCombo = new ComboBox();
            label2 = new Label();
            listeleBtn = new Button();
            ayCombo = new ComboBox();
            label1 = new Label();
            veri = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)veri).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(raporBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(yilCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listeleBtn);
            panel1.Controls.Add(ayCombo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(veri);
            panel1.Location = new Point(336, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 485);
            panel1.TabIndex = 0;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(666, 453);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(94, 29);
            cıkısBtn.TabIndex = 9;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(513, 453);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(123, 29);
            anaMenuBtn.TabIndex = 8;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // raporBtn
            // 
            raporBtn.Location = new Point(300, 453);
            raporBtn.Name = "raporBtn";
            raporBtn.Size = new Size(192, 29);
            raporBtn.TabIndex = 7;
            raporBtn.Text = "RAPORLAMA EKRANI";
            raporBtn.UseVisualStyleBackColor = true;
            raporBtn.Click += raporBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(29, 28);
            label3.Name = "label3";
            label3.Size = new Size(371, 25);
            label3.TabIndex = 6;
            label3.Text = "EN YUKSEK MAAS ALAN BES PERSONEL:";
            // 
            // yilCombo
            // 
            yilCombo.FormattingEnabled = true;
            yilCombo.Location = new Point(124, 200);
            yilCombo.Name = "yilCombo";
            yilCombo.Size = new Size(151, 28);
            yilCombo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 208);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 4;
            label2.Text = "YIL:";
            // 
            // listeleBtn
            // 
            listeleBtn.Location = new Point(84, 270);
            listeleBtn.Name = "listeleBtn";
            listeleBtn.Size = new Size(94, 29);
            listeleBtn.TabIndex = 3;
            listeleBtn.Text = "LİSTELE";
            listeleBtn.UseVisualStyleBackColor = true;
            listeleBtn.Click += listeleBtn_Click;
            // 
            // ayCombo
            // 
            ayCombo.FormattingEnabled = true;
            ayCombo.Location = new Point(124, 127);
            ayCombo.Name = "ayCombo";
            ayCombo.Size = new Size(151, 28);
            ayCombo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 130);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "AY:";
            // 
            // veri
            // 
            veri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            veri.Location = new Point(348, 111);
            veri.Name = "veri";
            veri.RowHeadersWidth = 51;
            veri.Size = new Size(352, 188);
            veri.TabIndex = 0;
            // 
            // EnYuksekMaasAlanBesPersonel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1417, 763);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "EnYuksekMaasAlanBesPersonel";
            Text = "EnYuksekMaasAlanBesPersonel";
            Load += EnYuksekMaasAlanBesPersonel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)veri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cıkısBtn;
        private Button anaMenuBtn;
        private Button raporBtn;
        private Label label3;
        private ComboBox yilCombo;
        private Label label2;
        private Button listeleBtn;
        private ComboBox ayCombo;
        private Label label1;
        private DataGridView veri;
    }
}