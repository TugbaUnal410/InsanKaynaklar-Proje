using InsankaynaklariProje.BLL;

namespace InsankaynaklariProje
{
    public partial class OturumForm : Form
    {
        public OturumForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            OturumBLL k = new OturumBLL();
            bool sonuc = k.Giris(kullaniciAdTxt.Text, sifreTxt.Text);
            if (sonuc)
            {
                AnaMenuForm a = new AnaMenuForm();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlis girildi!");
            }
        }
    }
}
