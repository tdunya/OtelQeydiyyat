using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OtelQeydiyyat
{
    public partial class Form1 : Form
    {
        public class Otaq
        {
            public int ID { get; set; }
            public int Nomre { get; set; }
            public int Mertebe { get; set; }
            public decimal Qiymet { get; set; }
            public string Status { get; set; }
            public int Sahesi { get; set; }
        }

        public class Gonaq
        {
            public int ID { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
            public string Pasport { get; set; }
            public DateTime GeliseTarixi { get; set; }
            public DateTime GedisheTarixi { get; set; }
            public int OtaqID { get; set; }

            public override string ToString()
            {
                return $"{Ad} {Soyad} - Otaq #{OtaqID}";
            }
        }

        List<Otaq> otaqlar = new List<Otaq>();
        List<Gonaq> qonaqlar = new List<Gonaq>();
        Otaq secilenOtaq = null;
        int gonaqSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OtaqlariYarat();
            MertebelerinComboBosalt();
            tabControl.TabPages[0].Text = "Sifariş";
            tabControl.TabPages[1].Text = "Çıxış";
        }

        private void OtaqlariYarat()
        {
            int id = 1;
            for (int mertebe = 1; mertebe <= 5; mertebe++)
            {
                for (int otaq = 1; otaq <= 10; otaq++)
                {
                    otaqlar.Add(new Otaq
                    {
                        ID = id,
                        Nomre = (mertebe * 100) + otaq,
                        Mertebe = mertebe,
                        Qiymet = 50 + (mertebe * 10),
                        Status = "Boş",
                        Sahesi = 70
                    });
                    id++;
                }
            }
        }

        private void MertebelerinComboBosalt()
        {
            comboBoxMertebe.Items.Add("- Mərtəbə Seçin -");
            for (int i = 1; i <= 5; i++)
            {
                comboBoxMertebe.Items.Add(i);
            }
            comboBoxMertebe.SelectedIndex = 0;
        }

        private void comboBoxMertebe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMertebe.SelectedIndex > 0)
            {
                int secilenMertebe = int.Parse(comboBoxMertebe.SelectedItem.ToString());
                OtaqlariListboxaYukle(secilenMertebe);
            }
            else
            {
                listBoxOtaqlar.Items.Clear();
            }
        }

        private void OtaqlariListboxaYukle(int mertebe)
        {
            listBoxOtaqlar.Items.Clear();
            var filtreliOtaqlar = otaqlar.Where(o => o.Mertebe == mertebe).ToList();

            foreach (var otaq in filtreliOtaqlar)
            {
                string melumat = $"Otaq #{otaq.Nomre} | Qiymət: {otaq.Qiymet}₼ | Status: {otaq.Status}";
                listBoxOtaqlar.Items.Add(melumat);
            }
        }

        private void listBoxOtaqlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOtaqlar.SelectedIndex >= 0)
            {
                int mertebe = int.Parse(comboBoxMertebe.SelectedItem.ToString());
                var filtreliOtaqlar = otaqlar.Where(o => o.Mertebe == mertebe).ToList();
                secilenOtaq = filtreliOtaqlar[listBoxOtaqlar.SelectedIndex];

                labelOtaqMelumat.Text = $"Otaq #{secilenOtaq.Nomre}\nMərtəbə: {secilenOtaq.Mertebe}\n" +
                                        $"Sahə: {secilenOtaq.Sahesi}m²\nStatus: {secilenOtaq.Status}\nQiymət: {secilenOtaq.Qiymet}₼";

                if (secilenOtaq.Status == "Boş")
                {
                    labelOtaqMelumat.BackColor = System.Drawing.Color.LightGreen;
                    buttonSifarisEt.Enabled = true;
                }
                else
                {
                    labelOtaqMelumat.BackColor = System.Drawing.Color.LightCoral;
                    buttonSifarisEt.Enabled = false;
                }
            }
        }

        private void buttonSifarisEt_Click(object sender, EventArgs e)
        {
            if (secilenOtaq == null)
            {
                MessageBox.Show("Otaq seçin!");
                return;
            }

            if (secilenOtaq.Status == "Dolu")
            {
                MessageBox.Show("Bu otaq dolu!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAd.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoyad.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefon.Text) ||
                string.IsNullOrWhiteSpace(textBoxPasport.Text))
            {
                MessageBox.Show("Bütün sahələri doldurun!");
                return;
            }

            if (dateTimePickerGelish.Value >= dateTimePickerGedish.Value)
            {
                MessageBox.Show("Gedişə tarixi gəliş tarixindən sonra olmalıdır!");
                return;
            }

            gonaqSayisi++;
            Gonaq yeniGonaq = new Gonaq
            {
                ID = gonaqSayisi,
                Ad = textBoxAd.Text,
                Soyad = textBoxSoyad.Text,
                Email = textBoxEmail.Text,
                Telefon = textBoxTelefon.Text,
                Pasport = textBoxPasport.Text,
                GeliseTarixi = dateTimePickerGelish.Value,
                GedisheTarixi = dateTimePickerGedish.Value,
                OtaqID = secilenOtaq.ID
            };

            qonaqlar.Add(yeniGonaq);
            secilenOtaq.Status = "Dolu";

            GosterOdenisMelumat(yeniGonaq, secilenOtaq);

            ComboBoxuYenile();

            TumunuTemizle();
            int mertebe = int.Parse(comboBoxMertebe.SelectedItem.ToString());
            OtaqlariListboxaYukle(mertebe);

            MessageBox.Show("Sifariş uğurla qeydiyyat edildi!");
        }

        private void GosterOdenisMelumat(Gonaq gonaq, Otaq otaq)
        {
            int gunSayisi = (gonaq.GedisheTarixi - gonaq.GeliseTarixi).Days;
            decimal toplam = otaq.Qiymet * gunSayisi;

            string odeniesMelumat = $"=== SIFARIŞ TƏSDIQ ===\n\n" +
                                    $"QONAQ:\n" +
                                    $"Ad: {gonaq.Ad}\n" +
                                    $"Soyad: {gonaq.Soyad}\n" +
                                    $"Email: {gonaq.Email}\n" +
                                    $"Telefon: {gonaq.Telefon}\n" +
                                    $"Pasport: {gonaq.Pasport}\n\n" +
                                    $"OTAQ:\n" +
                                    $"Nomrə: #{otaq.Nomre}\n" +
                                    $"Mərtəbə: {otaq.Mertebe}\n" +
                                    $"Sahə: {otaq.Sahesi}m²\n\n" +
                                    $"ÖDƏNIŞ:\n" +
                                    $"Gəliş: {gonaq.GeliseTarixi.ToShortDateString()}\n" +
                                    $"Gedişə: {gonaq.GedisheTarixi.ToShortDateString()}\n" +
                                    $"Gün Sayısı: {gunSayisi}\n" +
                                    $"Günlük Qiymət: {otaq.Qiymet}₼\n" +
                                    $"=======================\n" +
                                    $"TOPLAM: {toplam}₼";

            MessageBox.Show(odeniesMelumat, "ÖDƏNIŞ MƏLUMATΙ");
        }

        private void TumunuTemizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxEmail.Clear();
            textBoxTelefon.Clear();
            textBoxPasport.Clear();
            dateTimePickerGelish.Value = DateTime.Today;
            dateTimePickerGedish.Value = DateTime.Today.AddDays(1);
            labelOtaqMelumat.Text = "Otaq Seçin";
            labelOtaqMelumat.BackColor = System.Drawing.SystemColors.Control;
            secilenOtaq = null;
            listBoxOtaqlar.SelectedIndex = -1;
            comboBoxMertebe.SelectedIndex = 0;
        }
        
        private void comboBoxCixisQonaq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCixisQonaq.SelectedIndex >= 0)
            {
                Gonaq secilenGonaq = (Gonaq)comboBoxCixisQonaq.SelectedItem;
                int gunSayisi = (secilenGonaq.GedisheTarixi - secilenGonaq.GeliseTarixi).Days;
                var otaq = otaqlar.FirstOrDefault(o => o.ID == secilenGonaq.OtaqID);
                decimal toplam = otaq.Qiymet * gunSayisi;

                labelCixisMelumat.Text = $"Ad: {secilenGonaq.Ad} {secilenGonaq.Soyad}\n" +
                                         $"Email: {secilenGonaq.Email}\n" +
                                         $"Telefon: {secilenGonaq.Telefon}\n" +
                                         $"Otaq: #{otaq.Nomre}\n" +
                                         $"Gəliş: {secilenGonaq.GeliseTarixi.ToShortDateString()}\n" +
                                         $"Gedişə: {secilenGonaq.GedisheTarixi.ToShortDateString()}\n" +
                                         $"Gün Sayısı: {gunSayisi}\n" +
                                         $"TOPLAM: {toplam}₼";
            }
        }

        private void buttonCixis_Click(object sender, EventArgs e)
        {
            if (comboBoxCixisQonaq.SelectedIndex < 0)
            {
                MessageBox.Show("Qonaq seçin!");
                return;
            }

            Gonaq gonaq = (Gonaq)comboBoxCixisQonaq.SelectedItem;
            var otaq = otaqlar.FirstOrDefault(o => o.ID == gonaq.OtaqID);

            if (otaq != null)
            {
                otaq.Status = "Boş";
            }

            qonaqlar.Remove(gonaq);
            ComboBoxuYenile();

            MessageBox.Show($"{gonaq.Ad} {gonaq.Soyad} çıxış etdi!\nOtaq #{otaq.Nomre} indi boşdur.");
        }

        private void ComboBoxuYenile()
        {
            comboBoxCixisQonaq.Items.Clear();
            foreach (var gonaq in qonaqlar)
            {
                comboBoxCixisQonaq.Items.Add(gonaq);
            }
            labelCixisMelumat.Text = "Qonaq Seçin";
        }
    }
}
