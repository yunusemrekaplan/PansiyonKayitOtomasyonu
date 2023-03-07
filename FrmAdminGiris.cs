namespace PansiyonKayitOtomasyonu
{
    public partial class FrmAdminGiris : Form
    {
        const string KullaniciAdi = "Admin";
        const string Parola = "Admin123";

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TextKullaniciAdi.Text == KullaniciAdi && TextParola.Text == Parola)
            {
                FrmYeniMusteri fr = new FrmYeniMusteri();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre!!!");
            }
        }
    }
}