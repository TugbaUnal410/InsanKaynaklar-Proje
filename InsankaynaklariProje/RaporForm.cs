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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            raporData.DataSource = (new RaporBLL()).EnYuksekBesPerformans();
        }


        /*  private void button3_Click(object sender, EventArgs e)
          {
              DataTable dt = (new RaporBLL()).DepartmanPerformanslari();
              SutunGrafik(dt);
              PastaGrafik(dt);
              chartPasta.Visible = true;
              chartSutun.Visible = true;
          }*/

        private void personelRaporBtn_Click(object sender, EventArgs e)
        {
            RaporBLL bll = new RaporBLL();
            raporData.DataSource = bll.PersonelGetir();
        }

        private void departmanRaporlaBtn_Click(object sender, EventArgs e)
        {
            RaporBLL b = new RaporBLL();
            raporData.DataSource = b.DepartmanGetir();
        }

        private void izinraporlaBtn_Click(object sender, EventArgs e)
        {
            RaporBLL bll = new RaporBLL();
            raporData.DataSource = bll.IzinGetir();
        }

        private void maasRaporlaBtn_Click(object sender, EventArgs e)
        {
           MaaslarıGetirForm m=new MaaslarıGetirForm();
            m.Show();
            this.Close();
        }

        private void performansRaporlaBtn_Click(object sender, EventArgs e)
        {
            EnYuksekBesPerformansliPersonel form =new EnYuksekBesPerformansliPersonel();
            form.Show();
            this.Close();

        }

        private void personelleriGetir_Click(object sender, EventArgs e)
        {
            if (departmanCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Lutfen departman secini");
            }

            int departmanId = Convert.ToInt32(departmanCombo.SelectedValue);

            raporData.DataSource = (new RaporBLL()).PersonelGetir(departmanId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaasYukuForm m=new MaasYukuForm();
            m.Show();
            this.Close();
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            raporData.AutoGenerateColumns = true;
            
            raporData.DataSource = (new RaporBLL()).EnYuksekBesIzin();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            departmanCombo.DataSource = (new DepartmanBLL()).Departman();
            departmanCombo.DisplayMember = "Adi";
            departmanCombo.ValueMember = "ID";


        }

       /* private void performanslariGetirBtn_Click(object sender, EventArgs e)
        {
            raporData.DataSource = (new RaporBLL()).PerformansGetir();
        }*/

        private void top5maasBtn_Click(object sender, EventArgs e)
        {
           EnYuksekMaasAlanBesPersonel form =new EnYuksekMaasAlanBesPersonel();
            form.Show();
            this.Close();
        }

        private void maaslariGetirBtn_Click(object sender, EventArgs e)
        {
            DepartmanPerformansları d = new DepartmanPerformansları();
            d.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anaBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm ana = new AnaMenuForm();
            ana.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm oturum = new OturumForm();
            oturum.Show();
            this.Close();
        }
    }
}
