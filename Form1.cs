namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            
            {
                // ��renci bilgilerinin bir listesini doldurmak i�in gerekli i�lemleri yap�n.
                string adi = textBox9.Text; // Ad�
                string soyadi = textBox8.Text; // Soyad�
                string gun = textBox1.Text.Split('.')[0]; // G�n
                string ayAdi = GetMonthNameFromTextBox(textBox1.Text); // Ay Ad�
                string yil = textBox1.Text.Split('.')[2]; // Y�l
                double boy = Convert.ToDouble(textBox7.Text) / 100; // Boy cm girildiyse metreye �eviriyoruz
                double kilo = Convert.ToDouble(textBox6.Text);
                double vki = kilo / (boy * boy);
                string vkiStr = vki.ToString("F2");
                string burc = GetZodiacSign(Convert.ToInt32(gun), Convert.ToInt32(textBox1.Text.Split('.')[1]));

                // Ayn� veriler varsa eklemeyi engelle
                if (!listBox1.Items.Contains(adi)) listBox1.Items.Add(adi);
                if (!listBox2.Items.Contains(soyadi)) listBox2.Items.Add(soyadi);
                if (!listBox3.Items.Contains(gun)) listBox3.Items.Add(gun);
                if (!listBox4.Items.Contains(ayAdi)) listBox4.Items.Add(ayAdi);
                if (!listBox5.Items.Contains(yil)) listBox5.Items.Add(yil);
                if (!listBox6.Items.Contains(vkiStr)) listBox6.Items.Add(vkiStr);
                if (!listBox7.Items.Contains(burc)) listBox7.Items.Add(burc);

                // Bur� resmi ekleme
                pictureBox1.Image = GetZodiacImage(burc);

                // Yorum ekleme
                textBox2.Text = $"��renci {adi} {soyadi}, {burc} burcundand�r ve VKI de�eri {vkiStr}.";
            }

        }

        // Ay ad�n� almak i�in yard�mc� metod
        private string GetMonthNameFromTextBox(string dateText)
        {
            // Do�um tarihi "dd.mm.yyyy" format�nda varsay�lm��t�r.
            string[] aylar = { "Ocak", "�ubat", "Mart", "Nisan", "May�s", "Haziran", "Temmuz", "A�ustos", "Eyl�l", "Ekim", "Kas�m", "Aral�k" };
            int ayIndex = Convert.ToInt32(dateText.Split('.')[1]) - 1;
            return aylar[ayIndex];
        }

        // Bur� belirleme metodunu buraya ekleyin
        // Bur� belirleme metodunu buraya ekleyin
        private string GetZodiacSign(int day, int month)
        {
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                return "Kova";
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
                return "Bal�k";
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                return "Ko�";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                return "Bo�a";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 22))
                return "�kizler";
            else if ((month == 6 && day >= 23) || (month == 7 && day <= 22))
                return "Yenge�";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Aslan";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Ba�ak";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Terazi";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Akrep";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Yay";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
                return "O�lak";

            return "Bur� Bulunamad�"; // Default
        }

        private Image GetZodiacImage(string zodiac)
        {
            if (zodiac == "Kova")
                return Properties.Resources.Kova;
            if (zodiac == "Bal�k")
                return Properties.Resources.Bal�k;
            if (zodiac == "Ko�")
                return Properties.Resources.Koc;
            if (zodiac == "Bo�a")
                return Properties.Resources.Boga;
            if (zodiac == "�kizler")
                return Properties.Resources.Ikizler;
            if (zodiac == "Yenge�")
                return Properties.Resources.Yengec;
            if (zodiac == "Aslan")
                return Properties.Resources.Aslan;
            if (zodiac == "Ba�ak")
                return Properties.Resources.Basak;
            if (zodiac == "Terazi")
                return Properties.Resources.Terazi;
            if (zodiac == "Akrep")
                return Properties.Resources.Akrep;
            if (zodiac == "Yay")
                return Properties.Resources.Yay;
            if (zodiac == "O�lak")
                return Properties.Resources.Oglak;

            return null; // E�er bur� bulunamazsa null d�ner.
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

        