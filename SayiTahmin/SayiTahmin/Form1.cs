namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int rastgeleSayi;

        private void lblGirilen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 60;
            btnTahmin.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rastgeleSayi = rnd.Next(1, 100);
            progressBar1.Value = progressBar1.Maximum;
            btnTahmin.Enabled = true;
            lblBilgi.Text = "";
            label2.Text = "";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--;
            btnTahmin.Text = "Tahmin ET (" + progressBar1.Value + ")";
            switch (progressBar1.Value)
            {
                case 50:
                    label2.Text = "Galiba kaybedeceksin";
                    break;
                case 30:
                    label2.Text = "Sen Kaybetmek için yarýþýyosun";
                    break;
                case 20:
                    label2.Text = " Bu iþi yapamýyosun býrak";
                    break;
                case 0:
                    label2.Text = "Senden bi sikim olmaz";
                    timer1.Stop();
                    break;

            }

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            try
            {
                sayi = int.Parse(txtGirilenSayi.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblBilgi.Text = sayi.ToString();

            if (sayi < rastgeleSayi)
            {
                lblBilgi.Text += "Küçük sayi girdin";
            }
            else if (sayi > rastgeleSayi)
            {
                lblBilgi.Text += "Büyük sayi girdin";
            }
            else
            {
                lblBilgi.Text = "KAZANDIN AMK";
                int kacSaniyedeBildi = Math.Abs(progressBar1.Value - 60);

                if (kacSaniyedeBildi > 50 && kacSaniyedeBildi <= 60)
                {
                    label2.Text = "Son saniyede";

                }
                else if (kacSaniyedeBildi > 40 && kacSaniyedeBildi <= 50)
                {
                    label2.Text = "Son saniyede";
                }
                else if (kacSaniyedeBildi > 30 && kacSaniyedeBildi <= 40)
                {
                    label2.Text = " Helal olsun";
                }
                else if (kacSaniyedeBildi > 20 && kacSaniyedeBildi <= 30)
                {
                    label2.Text = "Gayet iyi";
                }
                else if(kacSaniyedeBildi > 10 && kacSaniyedeBildi <= 20)
                {
                    label2.Text = "Süper";


                }

            }
        }
    }
}
