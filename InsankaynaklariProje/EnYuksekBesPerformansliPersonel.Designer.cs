namespace InsankaynaklariProje
{
    partial class EnYuksekBesPerformansliPersonel
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
            bitisDate = new DateTimePicker();
            baslangicDate = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listeleBnt = new Button();
            performansData = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)performansData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bitisDate);
            panel1.Controls.Add(baslangicDate);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listeleBnt);
            panel1.Controls.Add(performansData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(255, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 450);
            panel1.TabIndex = 0;
            // 
            // bitisDate
            // 
            bitisDate.Location = new Point(170, 197);
            bitisDate.Name = "bitisDate";
            bitisDate.Size = new Size(250, 27);
            bitisDate.TabIndex = 12;
            // 
            // baslangicDate
            // 
            baslangicDate.Location = new Point(182, 111);
            baslangicDate.Name = "baslangicDate";
            baslangicDate.Size = new Size(250, 27);
            baslangicDate.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(795, 418);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "CIKIS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(639, 418);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 9;
            button2.Text = "ANA MENU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(481, 418);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 8;
            button1.Text = "RAPOR EKRANI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listeleBnt
            // 
            listeleBnt.Location = new Point(149, 273);
            listeleBnt.Name = "listeleBnt";
            listeleBnt.Size = new Size(94, 29);
            listeleBnt.TabIndex = 5;
            listeleBnt.Text = "LİSTELE";
            listeleBnt.UseVisualStyleBackColor = true;
            listeleBnt.Click += listeleBnt_Click;
            // 
            // performansData
            // 
            performansData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            performansData.Location = new Point(438, 75);
            performansData.Name = "performansData";
            performansData.RowHeadersWidth = 51;
            performansData.Size = new Size(451, 250);
            performansData.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 197);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "BİTİŞ TARİHİ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 116);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "BAŞLANGIÇ TARİHİ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(17, 22);
            label3.Name = "label3";
            label3.Size = new Size(415, 23);
            label3.TabIndex = 13;
            label3.Text = "EN YÜKSEK PERFORMANSA SAHİP BEŞ PERSONEL:";
            // 
            // EnYuksekBesPerformansliPersonel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x6121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1330, 707);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "EnYuksekBesPerformansliPersonel";
            Text = "EnYuksekBesPerformansliPersonel";
            Load += EnYuksekBesPerformansliPersonel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)performansData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button listeleBnt;
        private DataGridView performansData;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker bitisDate;
        private DateTimePicker baslangicDate;
        private Label label3;
    }
}