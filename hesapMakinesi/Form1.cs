namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double ilk_sayi;
        char islem;
        private bool ekran_temizle;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ekran_temizle)
            {
                textBox1.Text = "";
                ekran_temizle = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekran_temizle = true;
            ilk_sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekran_temizle = true;
            ilk_sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekran_temizle = true;
            ilk_sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekran_temizle = true;
            ilk_sayi = Convert.ToDouble(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double ikinci_sayi;
            double sonuc;
            ikinci_sayi = Convert.ToDouble(textBox1.Text);
            
            if(islem == '+')
            {
                sonuc = (ilk_sayi + ikinci_sayi);
                textBox1.Text = Convert.ToString(sonuc);
            }
            else if (islem == '-')
            {
                sonuc = (ilk_sayi - ikinci_sayi);
                textBox1.Text = Convert.ToString(sonuc);
            }
            else if (islem == '*')
            {
                sonuc = (ilk_sayi * ikinci_sayi);
                textBox1.Text = Convert.ToString(sonuc);
            }
            else if (islem == '/')
            { 
                sonuc = (ilk_sayi / ikinci_sayi);
                textBox1.Text = Convert.ToString(sonuc);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}