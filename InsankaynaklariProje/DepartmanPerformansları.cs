using InsankaynaklariProje.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InsankaynaklariProje
{
    public partial class DepartmanPerformansları : Form
    {
        public DepartmanPerformansları()
        {
            InitializeComponent();
        }

        public void SutunGrafik(DataTable dt)
        {
            chartSutun.Series.Clear();
            chartSutun.ChartAreas.Clear();//chartareas sütünların çizileceği yer.

            ChartArea ca = new ChartArea();
            ca.AxisX.Interval = 1;//bu kod sayesinde x de tek sütundan kurtulup her departman için ayrı sutun oluştuduk
            chartSutun.ChartAreas.Add(ca);
            

            Series se = new Series();
            se.ChartType = SeriesChartType.Column;//sütun grafiği çizdirdik
            se.IsValueShownAsLabel = true; //sütunların üzerinde sayıları gözterdik
            se.XValueType = ChartValueType.String;//x eksenine string veriler yazdırdık
            chartSutun.ChartAreas[0].AxisX.Interval = 1;//departmanları atlamadan sütun sütun yazdırır
            ca.AxisX.LabelStyle.Angle = -45; // X eksenindeki departman isimlerini çapraz yaz
            ca.AxisX.LabelStyle.IsEndLabelVisible = true; // Son etiketi gizlemeyi engelle
            se.IsXValueIndexed = true;
           
            se["PointWidth"] = "0.6";
            foreach (DataRow dr in dt.Rows)
            {
                se.Points.AddXY(dr["DepartmanAdi"], Convert.ToInt32(dr["ToplamPerformans"]));
            }
            chartSutun.Series.Add(se);
        }
        public void PastaGrafik(DataTable dt)
        {
            chartPasta.Series.Clear();
            Series s = new Series();
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            foreach (DataRow satir in dt.Rows)
            {
                s.Points.AddXY(satir["DepartmanAdi"].ToString(), Convert.ToInt32(satir["ToplamPerformans"]));
            }
            chartPasta.Series.Add(s);
        }
        public void DepertmanPerformansları_Load(object sender, EventArgs e)
        {
            

        }

        private void raporBtn_Click(object sender, EventArgs e)
        {
            RaporForm r = new RaporForm();
            r.ShowDialog();
            this.Close();
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm a = new AnaMenuForm();
            a.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm o = new OturumForm();
            o.Show();
            this.Close();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = (new RaporBLL()).DepartmanPerformanslari(baslangicDate.Value,bitisDate.Value);
            SutunGrafik(dt);
            PastaGrafik(dt);
        }
    }
}
    

    

