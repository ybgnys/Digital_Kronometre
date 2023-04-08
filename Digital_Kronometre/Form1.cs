namespace Digital_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            textBox1.Text = saat + ":" + dakika + ":" + saniye;
            if (saniye == 60)
            {
                dakika++;
                textBox1.Text = saat + ":" + dakika + ":" + saniye;
                saniye = 0;
                if (dakika == 60)
                {
                    saat++;
                    textBox1.Text = saat + ":" + dakika + ":" + saniye;
                    dakika = 0;
                    textBox1.Text = saat + ":" + dakika + ":" + saniye;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox1.Text = label1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            saat = 0;
            dakika = 0;
            saniye = 0;
            textBox1.Text = saat + ":" + dakika + ":" + saniye;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = textBox1.Text;
        }
    }
}