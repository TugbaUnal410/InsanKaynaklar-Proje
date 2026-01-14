namespace InsankaynaklariProje
{
    partial class DepartmanPerformansları
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            chartSutun = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPasta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label4 = new Label();
            listeleBtn = new Button();
            bitisDate = new DateTimePicker();
            baslangicDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            cıkısBtn = new Button();
            anaMenuBtn = new Button();
            raporBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)chartSutun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPasta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(398, 28);
            label1.TabIndex = 0;
            label1.Text = "DEPARTMAN PERFORMANS GRAFİKLERİ:";
            // 
            // chartSutun
            // 
            chartArea1.Name = "ChartArea1";
            chartSutun.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSutun.Legends.Add(legend1);
            chartSutun.Location = new Point(362, 86);
            chartSutun.Name = "chartSutun";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSutun.Series.Add(series1);
            chartSutun.Size = new Size(510, 145);
            chartSutun.TabIndex = 1;
            chartSutun.Text = "chart1";
            // 
            // chartPasta
            // 
            chartArea2.Name = "ChartArea1";
            chartPasta.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPasta.Legends.Add(legend2);
            chartPasta.Location = new Point(500, 254);
            chartPasta.Name = "chartPasta";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPasta.Series.Add(series2);
            chartPasta.Size = new Size(372, 229);
            chartPasta.TabIndex = 2;
            chartPasta.Text = "chart2";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listeleBtn);
            panel1.Controls.Add(bitisDate);
            panel1.Controls.Add(baslangicDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cıkısBtn);
            panel1.Controls.Add(anaMenuBtn);
            panel1.Controls.Add(raporBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chartPasta);
            panel1.Controls.Add(chartSutun);
            panel1.Location = new Point(240, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 592);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(344, 40);
            label4.TabIndex = 11;
            label4.Text = "Performanslar üçer aylık aralıkla kaydedilmektedir.\r\n Lütfen filtreleme yaparken bu ölçüte dikkat ediniz!\r\n";
            // 
            // listeleBtn
            // 
            listeleBtn.Location = new Point(54, 271);
            listeleBtn.Name = "listeleBtn";
            listeleBtn.Size = new Size(206, 29);
            listeleBtn.TabIndex = 10;
            listeleBtn.Text = "LİSTELE";
            listeleBtn.UseVisualStyleBackColor = true;
            listeleBtn.Click += listeleBtn_Click;
            // 
            // bitisDate
            // 
            bitisDate.Location = new Point(32, 172);
            bitisDate.Name = "bitisDate";
            bitisDate.Size = new Size(250, 27);
            bitisDate.TabIndex = 9;
            // 
            // baslangicDate
            // 
            baslangicDate.Location = new Point(32, 109);
            baslangicDate.Name = "baslangicDate";
            baslangicDate.Size = new Size(250, 27);
            baslangicDate.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 149);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "BİTİS TARİHİ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 86);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 6;
            label2.Text = "BASLANGIC TARİHİ:";
            // 
            // cıkısBtn
            // 
            cıkısBtn.Location = new Point(899, 560);
            cıkısBtn.Name = "cıkısBtn";
            cıkısBtn.Size = new Size(98, 29);
            cıkısBtn.TabIndex = 5;
            cıkısBtn.Text = "CIKIS";
            cıkısBtn.UseVisualStyleBackColor = true;
            cıkısBtn.Click += cıkısBtn_Click;
            // 
            // anaMenuBtn
            // 
            anaMenuBtn.Location = new Point(773, 560);
            anaMenuBtn.Name = "anaMenuBtn";
            anaMenuBtn.Size = new Size(110, 29);
            anaMenuBtn.TabIndex = 4;
            anaMenuBtn.Text = "ANA MENU";
            anaMenuBtn.UseVisualStyleBackColor = true;
            anaMenuBtn.Click += anaMenuBtn_Click;
            // 
            // raporBtn
            // 
            raporBtn.Location = new Point(587, 560);
            raporBtn.Name = "raporBtn";
            raporBtn.Size = new Size(180, 29);
            raporBtn.TabIndex = 3;
            raporBtn.Text = "RAPORLAMA EKRANI\r\n";
            raporBtn.UseVisualStyleBackColor = true;
            raporBtn.Click += raporBtn_Click;
            // 
            // DepartmanPerformansları
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1499958809_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1364, 744);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "DepartmanPerformansları";
            Text = "DepertmanPerformansları";
            Load += DepertmanPerformansları_Load;
            ((System.ComponentModel.ISupportInitialize)chartSutun).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPasta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSutun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPasta;
        private Panel panel1;
        private Button anaMenuBtn;
        private Button raporBtn;
        private Button cıkısBtn;
        private Button listeleBtn;
        private DateTimePicker bitisDate;
        private DateTimePicker baslangicDate;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}