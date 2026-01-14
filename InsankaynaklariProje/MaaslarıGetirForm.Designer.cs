namespace InsankaynaklariProje
{
    partial class MaaslarıGetirForm
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
            maasBtn = new Button();
            maasData = new DataGridView();
            label1 = new Label();
            baslangicDate = new DateTimePicker();
            label2 = new Label();
            bitisDate = new DateTimePicker();
            label4 = new Label();
            panel1 = new Panel();
            formBtn = new Button();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)maasData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // maasBtn
            // 
            maasBtn.Location = new Point(53, 255);
            maasBtn.Name = "maasBtn";
            maasBtn.Size = new Size(324, 29);
            maasBtn.TabIndex = 0;
            maasBtn.Text = "Maaslari Getir";
            maasBtn.UseVisualStyleBackColor = true;
            maasBtn.Click += maasBtn_Click;
            // 
            // maasData
            // 
            maasData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            maasData.Location = new Point(586, 65);
            maasData.Name = "maasData";
            maasData.RowHeadersWidth = 51;
            maasData.Size = new Size(563, 288);
            maasData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 166);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 2;
            label1.Text = "Baslangic Tarihi:";
            // 
            // baslangicDate
            // 
            baslangicDate.Location = new Point(186, 161);
            baslangicDate.Name = "baslangicDate";
            baslangicDate.Size = new Size(281, 27);
            baslangicDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 214);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Bitis Tarihi:";
            // 
            // bitisDate
            // 
            bitisDate.Location = new Point(186, 214);
            bitisDate.Name = "bitisDate";
            bitisDate.Size = new Size(281, 27);
            bitisDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 36);
            label4.Name = "label4";
            label4.Size = new Size(306, 28);
            label4.TabIndex = 7;
            label4.Text = "MAAS GORUNTELEME EKRANI:\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(formBtn);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maasBtn);
            panel1.Controls.Add(maasData);
            panel1.Controls.Add(bitisDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(baslangicDate);
            panel1.Location = new Point(114, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 460);
            panel1.TabIndex = 8;
            // 
            // formBtn
            // 
            formBtn.Location = new Point(719, 428);
            formBtn.Name = "formBtn";
            formBtn.Size = new Size(140, 29);
            formBtn.TabIndex = 10;
            formBtn.Text = "RAPOR EKRANI";
            formBtn.UseVisualStyleBackColor = true;
            formBtn.Click += formBtn_Click;
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(1038, 428);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(134, 29);
            cıkısBtn.TabIndex = 9;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(878, 428);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(140, 29);
            anaMenuBtn.TabIndex = 8;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // MaaslarıGetirForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1375, 748);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MaaslarıGetirForm";
            Text = "MaaslarıGetir";
            Load += MaaslarıGetirForm_Load;
            ((System.ComponentModel.ISupportInitialize)maasData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button maasBtn;
        private DataGridView maasData;
        private Label label1;
        private DateTimePicker baslangicDate;
        private Label label2;
        private DateTimePicker bitisDate;
        private Label label4;
        private Panel panel1;
        private Button cıkısBtn;
        private Button anaMenuBtn;
        private Button formBtn;
    }
}