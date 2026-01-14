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

namespace InsankaynaklariProje
{
    public partial class EnYuksekBesPerformansliPersonel : Form
    {
        public EnYuksekBesPerformansliPersonel()
        {
            InitializeComponent();
        }

        private void EnYuksekBesPerformansliPersonel_Load(object sender, EventArgs e)
        {

        }

        private void listeleBnt_Click(object sender, EventArgs e)
        {
           
            performansData.DataSource = (new RaporBLL()).PerformansGetir(baslangicDate.Value, bitisDate.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OturumForm form = new OturumForm();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaMenuForm form = new AnaMenuForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporForm form = new RaporForm();
            form.Show();
            this.Close();
        }
    }
}
