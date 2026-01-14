namespace InsankaynaklariProje
{
    partial class RaporForm
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
            personelRaporBtn = new Button();
            departmanRaporlaBtn = new Button();
            izinraporlaBtn = new Button();
            maasRaporlaBtn = new Button();
            performansRaporlaBtn = new Button();
            raporData = new DataGridView();
            departmanCombo = new ComboBox();
            personelleriGetir = new Button();
            personelIzinBtn = new Button();
            maaslariGetirBtn = new Button();
            top5izinBtn = new Button();
            top5maasBtn = new Button();
            top5performansBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            cıkısBtn = new Button();
            anaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)raporData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // personelRaporBtn
            // 
            personelRaporBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            personelRaporBtn.Location = new Point(14, 49);
            personelRaporBtn.Name = "personelRaporBtn";
            personelRaporBtn.Size = new Size(246, 29);
            personelRaporBtn.TabIndex = 0;
            personelRaporBtn.Text = "PERSONEL RAPORLA";
            personelRaporBtn.UseVisualStyleBackColor = true;
            personelRaporBtn.Click += personelRaporBtn_Click;
            // 
            // departmanRaporlaBtn
            // 
            departmanRaporlaBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            departmanRaporlaBtn.Location = new Point(13, 84);
            departmanRaporlaBtn.Name = "departmanRaporlaBtn";
            departmanRaporlaBtn.Size = new Size(247, 29);
            departmanRaporlaBtn.TabIndex = 1;
            departmanRaporlaBtn.Text = "DEPARTMAN RAPORLA";
            departmanRaporlaBtn.UseVisualStyleBackColor = true;
            departmanRaporlaBtn.Click += departmanRaporlaBtn_Click;
            // 
            // izinraporlaBtn
            // 
            izinraporlaBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            izinraporlaBtn.Location = new Point(14, 119);
            izinraporlaBtn.Name = "izinraporlaBtn";
            izinraporlaBtn.Size = new Size(246, 29);
            izinraporlaBtn.TabIndex = 2;
            izinraporlaBtn.Text = "IZINLERI RAPORLA";
            izinraporlaBtn.UseVisualStyleBackColor = true;
            izinraporlaBtn.Click += izinraporlaBtn_Click;
            // 
            // maasRaporlaBtn
            // 
            maasRaporlaBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            maasRaporlaBtn.Location = new Point(14, 154);
            maasRaporlaBtn.Name = "maasRaporlaBtn";
            maasRaporlaBtn.Size = new Size(246, 29);
            maasRaporlaBtn.TabIndex = 3;
            maasRaporlaBtn.Text = "MAAS RAPORLA";
            maasRaporlaBtn.UseVisualStyleBackColor = true;
            maasRaporlaBtn.Click += maasRaporlaBtn_Click;
            // 
            // performansRaporlaBtn
            // 
            performansRaporlaBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            performansRaporlaBtn.Location = new Point(13, 189);
            performansRaporlaBtn.Name = "performansRaporlaBtn";
            performansRaporlaBtn.Size = new Size(246, 29);
            performansRaporlaBtn.TabIndex = 4;
            performansRaporlaBtn.Text = "PERFORMANSLARI RAPORLA";
            performansRaporlaBtn.UseVisualStyleBackColor = true;
            performansRaporlaBtn.Click += performansRaporlaBtn_Click;
            // 
            // raporData
            // 
            raporData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            raporData.Location = new Point(328, 61);
            raporData.Name = "raporData";
            raporData.RowHeadersWidth = 51;
            raporData.Size = new Size(887, 594);
            raporData.TabIndex = 5;
            // 
            // departmanCombo
            // 
            departmanCombo.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            departmanCombo.FormattingEnabled = true;
            departmanCombo.Location = new Point(14, 252);
            departmanCombo.Name = "departmanCombo";
            departmanCombo.Size = new Size(250, 23);
            departmanCombo.TabIndex = 6;
            // 
            // personelleriGetir
            // 
            personelleriGetir.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            personelleriGetir.Location = new Point(14, 281);
            personelleriGetir.Name = "personelleriGetir";
            personelleriGetir.Size = new Size(259, 48);
            personelleriGetir.TabIndex = 7;
            personelleriGetir.Text = "DEPARTMANDAKI PERSONELLERI GETIR";
            personelleriGetir.UseVisualStyleBackColor = true;
            personelleriGetir.Click += personelleriGetir_Click;
            // 
            // personelIzinBtn
            // 
            personelIzinBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            personelIzinBtn.Location = new Point(25, 377);
            personelIzinBtn.Name = "personelIzinBtn";
            personelIzinBtn.Size = new Size(255, 38);
            personelIzinBtn.TabIndex = 8;
            personelIzinBtn.Text = "DEPARTMANLARIN MAAS YUKU\r\n";
            personelIzinBtn.UseVisualStyleBackColor = true;
            personelIzinBtn.Click += button2_Click;
            // 
            // maaslariGetirBtn
            // 
            maaslariGetirBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            maaslariGetirBtn.Location = new Point(25, 433);
            maaslariGetirBtn.Name = "maaslariGetirBtn";
            maaslariGetirBtn.Size = new Size(255, 43);
            maaslariGetirBtn.TabIndex = 9;
            maaslariGetirBtn.Text = "DEPARTMAN PERFORMASLARI\r\n";
            maaslariGetirBtn.UseVisualStyleBackColor = true;
            maaslariGetirBtn.Click += maaslariGetirBtn_Click;
            // 
            // top5izinBtn
            // 
            top5izinBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            top5izinBtn.Location = new Point(21, 482);
            top5izinBtn.Name = "top5izinBtn";
            top5izinBtn.Size = new Size(256, 48);
            top5izinBtn.TabIndex = 11;
            top5izinBtn.Text = "EN YUKSEK IZIN ALAN BES PERSONEL";
            top5izinBtn.UseVisualStyleBackColor = true;
            top5izinBtn.Click += button5_Click;
            // 
            // top5maasBtn
            // 
            top5maasBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            top5maasBtn.Location = new Point(25, 536);
            top5maasBtn.Name = "top5maasBtn";
            top5maasBtn.Size = new Size(251, 51);
            top5maasBtn.TabIndex = 12;
            top5maasBtn.Text = "EN YUKSEK MAAS ALAN BES PERSONEL";
            top5maasBtn.UseVisualStyleBackColor = true;
            top5maasBtn.Click += top5maasBtn_Click;
            // 
            // top5performansBtn
            // 
            top5performansBtn.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            top5performansBtn.Location = new Point(21, 593);
            top5performansBtn.Name = "top5performansBtn";
            top5performansBtn.Size = new Size(255, 53);
            top5performansBtn.TabIndex = 13;
            top5performansBtn.Text = "EN YUKSEK PERFORMANSI OLAN BES PERSONEL";
            top5performansBtn.UseVisualStyleBackColor = true;
            top5performansBtn.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(328, 15);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 14;
            label1.Text = "ISTENILEN RAPOR:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaBtn);
            panel1.Controls.Add(departmanCombo);
            panel1.Controls.Add(personelRaporBtn);
            panel1.Controls.Add(personelleriGetir);
            panel1.Controls.Add(top5maasBtn);
            panel1.Controls.Add(departmanRaporlaBtn);
            panel1.Controls.Add(personelIzinBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(top5izinBtn);
            panel1.Controls.Add(izinraporlaBtn);
            panel1.Controls.Add(maaslariGetirBtn);
            panel1.Controls.Add(top5performansBtn);
            panel1.Controls.Add(maasRaporlaBtn);
            panel1.Controls.Add(performansRaporlaBtn);
            panel1.Controls.Add(raporData);
            panel1.Location = new Point(44, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 721);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(1155, 680);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(103, 29);
            cıkısBtn.TabIndex = 16;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaBtn
            // 
            anaBtn.Location = new Point(1024, 680);
            anaBtn.Name = "anaBtn";
            anaBtn.Size = new Size(108, 29);
            anaBtn.TabIndex = 15;
            anaBtn.Text = "ANA MENU";
            anaBtn.UseVisualStyleBackColor = true;
            anaBtn.Click += anaBtn_Click;
            // 
            // RaporForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1373, 745);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "RaporForm";
            Text = "RaporForm";
            Load += RaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)raporData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button personelRaporBtn;
        private Button departmanRaporlaBtn;
        private Button izinraporlaBtn;
        private Button maasRaporlaBtn;
        private Button performansRaporlaBtn;
        private DataGridView raporData;
        private ComboBox departmanCombo;
        private Button personelleriGetir;
        private Button personelIzinBtn;
        private Button maaslariGetirBtn;
        private Button top5izinBtn;
        private Button top5maasBtn;
        private Button top5performansBtn;
        private Label label1;
        private Panel panel1;
        private Button cıkısBtn;
        private Button anaBtn;
    }
}