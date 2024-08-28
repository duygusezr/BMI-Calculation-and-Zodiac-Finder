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
                // Öðrenci bilgilerinin bir listesini doldurmak için gerekli iþlemleri yapýn.
                string adi = textBox9.Text; // Adý
                string soyadi = textBox8.Text; // Soyadý
                string gun = textBox1.Text.Split('.')[0]; // Gün
                string ayAdi = GetMonthNameFromTextBox(textBox1.Text); // Ay Adý
                string yil = textBox1.Text.Split('.')[2]; // Yýl
                double boy = Convert.ToDouble(textBox7.Text) / 100; // Boy cm girildiyse metreye çeviriyoruz
                double kilo = Convert.ToDouble(textBox6.Text);
                double vki = kilo / (boy * boy);
                string vkiStr = vki.ToString("F2");
                string burc = GetZodiacSign(Convert.ToInt32(gun), Convert.ToInt32(textBox1.Text.Split('.')[1]));

                // Ayný veriler varsa eklemeyi engelle
                if (!listBox1.Items.Contains(adi)) listBox1.Items.Add(adi);
                if (!listBox2.Items.Contains(soyadi)) listBox2.Items.Add(soyadi);
                if (!listBox3.Items.Contains(gun)) listBox3.Items.Add(gun);
                if (!listBox4.Items.Contains(ayAdi)) listBox4.Items.Add(ayAdi);
                if (!listBox5.Items.Contains(yil)) listBox5.Items.Add(yil);
                if (!listBox6.Items.Contains(vkiStr)) listBox6.Items.Add(vkiStr);
                if (!listBox7.Items.Contains(burc)) listBox7.Items.Add(burc);

                // Burç resmi ekleme
                pictureBox1.Image = GetZodiacImage(burc);

                // Yorum ekleme
                textBox2.Text = $"Öðrenci {adi} {soyadi}, {burc} burcundandýr ve VKI deðeri {vkiStr}.";
            }

        }

        // Ay adýný almak için yardýmcý metod
        private string GetMonthNameFromTextBox(string dateText)
        {
            // Doðum tarihi "dd.mm.yyyy" formatýnda varsayýlmýþtýr.
            string[] aylar = { "Ocak", "Þubat", "Mart", "Nisan", "Mayýs", "Haziran", "Temmuz", "Aðustos", "Eylül", "Ekim", "Kasým", "Aralýk" };
            int ayIndex = Convert.ToInt32(dateText.Split('.')[1]) - 1;
            return aylar[ayIndex];
        }

        // Burç belirleme metodunu buraya ekleyin
        // Burç belirleme metodunu buraya ekleyin
        private string GetZodiacSign(int day, int month)
        {
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                return "Kova";
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
                return "Balýk";
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                return "Koç";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                return "Boða";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 22))
                return "Ýkizler";
            else if ((month == 6 && day >= 23) || (month == 7 && day <= 22))
                return "Yengeç";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Aslan";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Baþak";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Terazi";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Akrep";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Yay";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 20))
                return "Oðlak";

            return "Burç Bulunamadý"; // Default
        }

        private Image GetZodiacImage(string zodiac)
        {
            if (zodiac == "Kova")
                return Properties.Resources.Kova;
            if (zodiac == "Balýk")
                return Properties.Resources.Balýk;
            if (zodiac == "Koç")
                return Properties.Resources.Koc;
            if (zodiac == "Boða")
                return Properties.Resources.Boga;
            if (zodiac == "Ýkizler")
                return Properties.Resources.Ikizler;
            if (zodiac == "Yengeç")
                return Properties.Resources.Yengec;
            if (zodiac == "Aslan")
                return Properties.Resources.Aslan;
            if (zodiac == "Baþak")
                return Properties.Resources.Basak;
            if (zodiac == "Terazi")
                return Properties.Resources.Terazi;
            if (zodiac == "Akrep")
                return Properties.Resources.Akrep;
            if (zodiac == "Yay")
                return Properties.Resources.Yay;
            if (zodiac == "Oðlak")
                return Properties.Resources.Oglak;

            return null; // Eðer burç bulunamazsa null döner.
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

        