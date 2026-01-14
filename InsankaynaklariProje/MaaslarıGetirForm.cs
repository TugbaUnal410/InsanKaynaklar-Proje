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
    public partial class MaaslarıGetirForm : Form
    {
        public MaaslarıGetirForm()
        {
            InitializeComponent();
        }

        private void maasBtn_Click(object sender, EventArgs e)
        {

            maasData.DataSource = (new RaporBLL()).MaasGetir(baslangicDate.Value, bitisDate.Value);


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

        private void formBtn_Click(object sender, EventArgs e)
        {
            RaporForm rapor = new RaporForm();
            rapor.Show();
            this.Close();
        }

        private void MaaslarıGetirForm_Load(object sender, EventArgs e)
        {

        }
    }
}
