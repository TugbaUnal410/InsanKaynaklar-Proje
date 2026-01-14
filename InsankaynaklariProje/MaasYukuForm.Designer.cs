namespace InsankaynaklariProje
{
    partial class MaasYukuForm
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
            raporBtn = new Button();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            label3 = new Label();
            listeleBtn = new Button();
            departmanMaasData = new DataGridView();
            yilCombo = new ComboBox();
            ayCombo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)departmanMaasData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(raporBtn);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listeleBtn);
            panel1.Controls.Add(departmanMaasData);
            panel1.Controls.Add(yilCombo);
            panel1.Controls.Add(ayCombo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(239, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 419);
            panel1.TabIndex = 0;
            // 
            // raporBtn
            // 
            raporBtn.Location = new Point(458, 387);
            raporBtn.Name = "raporBtn";
            raporBtn.Size = new Size(146, 29);
            raporBtn.TabIndex = 9;
            raporBtn.Text = "RAPOR EKRANI";
            raporBtn.UseVisualStyleBackColor = true;
            raporBtn.Click += raporBtn_Click;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(763, 387);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(110, 29);
            cıkısBtn.TabIndex = 8;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(625, 387);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(121, 29);
            anaMenuBtn.TabIndex = 7;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 31);
            label3.Name = "label3";
            label3.Size = new Size(265, 28);
            label3.TabIndex = 6;
            label3.Text = "DEPARTMAN MAAS YUKU:\r\n";
            // 
            // listeleBtn
            // 
            listeleBtn.Location = new Point(212, 270);
            listeleBtn.Name = "listeleBtn";
            listeleBtn.Size = new Size(171, 29);
            listeleBtn.TabIndex = 5;
            listeleBtn.Text = "LISTELE";
            listeleBtn.UseVisualStyleBackColor = true;
            listeleBtn.Click += listeleBtn_Click;
            // 
            // departmanMaasData
            // 
            departmanMaasData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmanMaasData.Location = new Point(458, 111);
            departmanMaasData.Name = "departmanMaasData";
            departmanMaasData.RowHeadersWidth = 51;
            departmanMaasData.Size = new Size(380, 188);
            departmanMaasData.TabIndex = 4;
            // 
            // yilCombo
            // 
            yilCombo.FormattingEnabled = true;
            yilCombo.Location = new Point(262, 207);
            yilCombo.Name = "yilCombo";
            yilCombo.Size = new Size(151, 28);
            yilCombo.TabIndex = 3;
            // 
            // ayCombo
            // 
            ayCombo.FormattingEnabled = true;
            ayCombo.Location = new Point(262, 148);
            ayCombo.Name = "ayCombo";
            ayCombo.Size = new Size(151, 28);
            ayCombo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 215);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "YIL:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 156);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "AY:";
            // 
            // MaasYukuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1316, 703);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MaasYukuForm";
            Text = "MaasYukuForm";
            Load += MaasYukuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)departmanMaasData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button listeleBtn;
        private DataGridView departmanMaasData;
        private ComboBox yilCombo;
        private ComboBox ayCombo;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button raporBtn;
        private Button cıkısBtn;
        private Button anaMenuBtn;
    }
}