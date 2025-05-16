using System.Windows.Forms;

namespace usatam_bumudur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim1 = textBox1.Text;
            string isim2 = textBox2.Text;
            string cevap = textBox3.Text;
            string yuzde = textBox4.Text;



            Random rnd = new Random();
            int sayi = rnd.Next(0, 100);

            if (textBox1.Text == "emre")
            {
                sayi = 9999999;
            }


            yuzde = $"Seni %{sayi} kadar seviyor yani";

            if (sayi > 90) {
                cevap = "seni nasıl sevdiğini anlatamam bile ☻";
                pictureBox1.Image = Image.FromFile("C:\\Users\\k3tr0n\\Desktop\\sevgi ölçer\\usatam bumudur\\resimler\\90.jpg");
            }


            else if (sayi > 75) {
                cevap = "Seni çok seviyor";
                pictureBox1.Image = Image.FromFile("C:\\Users\\k3tr0n\\Desktop\\sevgi ölçer\\usatam bumudur\\resimler\\75.jpg");
            }


            else if (sayi > 50) {
                cevap = "Seni arkadaşça seviyor";
                pictureBox1.Image = Image.FromFile("C:\\Users\\k3tr0n\\Desktop\\sevgi ölçer\\usatam bumudur\\resimler\\50.jpg");
            }

            else if (sayi > 25) { 
            cevap = "Görürse selam verir anca";
            pictureBox1.Image = Image.FromFile("C:\\Users\\k3tr0n\\Desktop\\sevgi ölçer\\usatam bumudur\\resimler\\25.jpg");
             }

            else { 
                cevap = "Yazman hata seni hiç sevmiyor";
                pictureBox1.Image = Image.FromFile("C:\\Users\\k3tr0n\\Desktop\\sevgi ölçer\\usatam bumudur\\resimler\\25.jpg");
             }

            textBox3.Text = cevap;
            textBox4 .Text = yuzde;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
