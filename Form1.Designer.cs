Dizayn Kodu
namespace OtelQeydiyyat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new System.Windows.Forms.TabControl();
            tabSifaris = new System.Windows.Forms.TabPage();
            tabCixis = new System.Windows.Forms.TabPage();

            System.Windows.Forms.Panel panelSol = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel panelSag = new System.Windows.Forms.Panel();

            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            textBoxAd = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            textBoxSoyad = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
            textBoxTelefon = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
            textBoxPasport = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label label6 = new System.Windows.Forms.Label();
            dateTimePickerGelish = new System.Windows.Forms.DateTimePicker();
            System.Windows.Forms.Label label7 = new System.Windows.Forms.Label();
            dateTimePickerGedish = new System.Windows.Forms.DateTimePicker();

            System.Windows.Forms.Label label8 = new System.Windows.Forms.Label();
            comboBoxMertebe = new System.Windows.Forms.ComboBox();
            System.Windows.Forms.Label label9 = new System.Windows.Forms.Label();
            listBoxOtaqlar = new System.Windows.Forms.ListBox();
            labelOtaqMelumat = new System.Windows.Forms.Label();

            buttonSifarisEt = new System.Windows.Forms.Button();

            System.Windows.Forms.Label labelCixisBasliq = new System.Windows.Forms.Label();
            System.Windows.Forms.Label labelCixisQonaqSec = new System.Windows.Forms.Label();
            comboBoxCixisQonaq = new System.Windows.Forms.ComboBox();
            labelCixisMelumat = new System.Windows.Forms.Label();
            buttonCixis = new System.Windows.Forms.Button();

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Text = "Otel Qeydiyyat Sistemi";
            this.Font = new System.Drawing.Font("Arial", 10);

            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Width = 1200;
            tabControl.Height = 600;
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;

            tabSifaris.BackColor = System.Drawing.SystemColors.Control;
            tabCixis.BackColor = System.Drawing.SystemColors.Control;

            panelSol.Width = 400;
            panelSol.Dock = System.Windows.Forms.DockStyle.Left;
            panelSol.BackColor = System.Drawing.Color.WhiteSmoke;
            panelSol.Padding = new System.Windows.Forms.Padding(20);

            int yPos = 10;

            label1.Text = "Ad:";
            label1.Location = new System.Drawing.Point(10, yPos);
            label1.Width = 100;
            panelSol.Controls.Add(label1);

            textBoxAd.Location = new System.Drawing.Point(10, yPos + 25);
            textBoxAd.Width = 360;
            textBoxAd.Height = 30;
            panelSol.Controls.Add(textBoxAd);
            yPos += 65;

            label2.Text = "Soyad:";
            label2.Location = new System.Drawing.Point(10, yPos);
            label2.Width = 100;
            panelSol.Controls.Add(label2);

            textBoxSoyad.Location = new System.Drawing.Point(10, yPos + 25);
            textBoxSoyad.Width = 360;
            textBoxSoyad.Height = 30;
            panelSol.Controls.Add(textBoxSoyad);
            yPos += 65;

            label3.Text = "Email:";
            label3.Location = new System.Drawing.Point(10, yPos);
            label3.Width = 100;
            panelSol.Controls.Add(label3);

            textBoxEmail.Location = new System.Drawing.Point(10, yPos + 25);
            textBoxEmail.Width = 360;
            textBoxEmail.Height = 30;
            panelSol.Controls.Add(textBoxEmail);
            yPos += 65;

            label4.Text = "Telefon:";
            label4.Location = new System.Drawing.Point(10, yPos);
            label4.Width = 100;
            panelSol.Controls.Add(label4);

            textBoxTelefon.Location = new System.Drawing.Point(10, yPos + 25);
            textBoxTelefon.Width = 360;
            textBoxTelefon.Height = 30;
            panelSol.Controls.Add(textBoxTelefon);
            yPos += 65;

            label5.Text = "Pasport:";
            label5.Location = new System.Drawing.Point(10, yPos);
            label5.Width = 100;
            panelSol.Controls.Add(label5);

            textBoxPasport.Location = new System.Drawing.Point(10, yPos + 25);
            textBoxPasport.Width = 360;
            textBoxPasport.Height = 30;
            panelSol.Controls.Add(textBoxPasport);
            yPos += 65;

            label6.Text = "Gəliş Tarixi:";
            label6.Location = new System.Drawing.Point(10, yPos);
            label6.Width = 100;
            panelSol.Controls.Add(label6);

            dateTimePickerGelish.Location = new System.Drawing.Point(10, yPos + 25);
            dateTimePickerGelish.Width = 360;
            dateTimePickerGelish.Height = 30;
            panelSol.Controls.Add(dateTimePickerGelish);
            yPos += 65;

            label7.Text = "Gedişə Tarixi:";
            label7.Location = new System.Drawing.Point(10, yPos);
            label7.Width = 100;
            panelSol.Controls.Add(label7);

            dateTimePickerGedish.Location = new System.Drawing.Point(10, yPos + 25);
            dateTimePickerGedish.Width = 360;
            dateTimePickerGedish.Height = 30;
            panelSol.Controls.Add(dateTimePickerGedish);
            yPos += 65;

            buttonSifarisEt.Text = "SİFARİŞ ET";
            buttonSifarisEt.Location = new System.Drawing.Point(10, yPos);
            buttonSifarisEt.Width = 360;
            buttonSifarisEt.Height = 40;
            buttonSifarisEt.BackColor = System.Drawing.Color.DodgerBlue;
            buttonSifarisEt.ForeColor = System.Drawing.Color.White;
            buttonSifarisEt.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            buttonSifarisEt.Click += new System.EventHandler(buttonSifarisEt_Click);
            panelSol.Controls.Add(buttonSifarisEt);

            tabSifaris.Controls.Add(panelSol);

            panelSag.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSag.BackColor = System.Drawing.Color.White;
            panelSag.Padding = new System.Windows.Forms.Padding(20);

            label8.Text = "MƏRTƏBƏ SEÇİN:";
            label8.Location = new System.Drawing.Point(20, 20);
            label8.Width = 300;
            label8.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            panelSag.Controls.Add(label8);

            comboBoxMertebe.Location = new System.Drawing.Point(20, 50);
            comboBoxMertebe.Width = 250;
            comboBoxMertebe.Height = 30;
            comboBoxMertebe.SelectedIndexChanged += new System.EventHandler(comboBoxMertebe_SelectedIndexChanged);
            panelSag.Controls.Add(comboBoxMertebe);

            label9.Text = "BOŞOTAQLAR:";
            label9.Location = new System.Drawing.Point(20, 100);
            label9.Width = 300;
            label9.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            panelSag.Controls.Add(label9);

            listBoxOtaqlar.Location = new System.Drawing.Point(20, 130);
            listBoxOtaqlar.Width = 750;
            listBoxOtaqlar.Height = 300;
            listBoxOtaqlar.SelectedIndexChanged += new System.EventHandler(listBoxOtaqlar_SelectedIndexChanged);
            panelSag.Controls.Add(listBoxOtaqlar);

            labelOtaqMelumat.Text = "Otaq Seçin";
            labelOtaqMelumat.Location = new System.Drawing.Point(20, 440);
            labelOtaqMelumat.Width = 750;
            labelOtaqMelumat.Height = 120;
            labelOtaqMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelOtaqMelumat.BackColor = System.Drawing.SystemColors.Control;
            labelOtaqMelumat.Padding = new System.Windows.Forms.Padding(10);
            panelSag.Controls.Add(labelOtaqMelumat);

            tabSifaris.Controls.Add(panelSag);

            labelCixisBasliq.Text = "QONAQ ÇIXIŞI";
            labelCixisBasliq.Location = new System.Drawing.Point(30, 30);
            labelCixisBasliq.Width = 400;
            labelCixisBasliq.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            labelCixisBasliq.ForeColor = System.Drawing.Color.DarkRed;
            tabCixis.Controls.Add(labelCixisBasliq);

            labelCixisQonaqSec.Text = "Çıxış edəcək qonaq seçin:";
            labelCixisQonaqSec.Location = new System.Drawing.Point(30, 80);
            labelCixisQonaqSec.Width = 400;
            labelCixisQonaqSec.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            tabCixis.Controls.Add(labelCixisQonaqSec);

            comboBoxCixisQonaq.Location = new System.Drawing.Point(30, 110);
            comboBoxCixisQonaq.Width = 500;
            comboBoxCixisQonaq.Height = 30;
            comboBoxCixisQonaq.SelectedIndexChanged += new System.EventHandler(comboBoxCixisQonaq_SelectedIndexChanged);
            tabCixis.Controls.Add(comboBoxCixisQonaq);

            labelCixisMelumat.Text = "Qonaq Seçin";
            labelCixisMelumat.Location = new System.Drawing.Point(30, 160);
            labelCixisMelumat.Width = 500;
            labelCixisMelumat.Height = 150;
            labelCixisMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelCixisMelumat.BackColor = System.Drawing.Color.LightYellow;
            labelCixisMelumat.Padding = new System.Windows.Forms.Padding(10);
            labelCixisMelumat.Font = new System.Drawing.Font("Arial", 11);
            tabCixis.Controls.Add(labelCixisMelumat);

            buttonCixis.Text = "ÇIXIŞI TAMAMLA";
            buttonCixis.Location = new System.Drawing.Point(30, 330);
            buttonCixis.Width = 500;
            buttonCixis.Height = 45;
            buttonCixis.BackColor = System.Drawing.Color.DarkRed;
            buttonCixis.ForeColor = System.Drawing.Color.White;
            buttonCixis.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            buttonCixis.Click += new System.EventHandler(buttonCixis_Click);
            tabCixis.Controls.Add(buttonCixis);

            this.Controls.Add(tabControl);
            tabControl.TabPages.Add(tabSifaris);
            tabControl.TabPages.Add(tabCixis);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSifaris;
        private System.Windows.Forms.TabPage tabCixis;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxPasport;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelish;
        private System.Windows.Forms.DateTimePicker dateTimePickerGedish;
        private System.Windows.Forms.ComboBox comboBoxMertebe;
        private System.Windows.Forms.ListBox listBoxOtaqlar;
        private System.Windows.Forms.Label labelOtaqMelumat;
        private System.Windows.Forms.Button buttonSifarisEt;
        private System.Windows.Forms.ComboBox comboBoxCixisQonaq;
        private System.Windows.Forms.Label labelCixisMelumat;
        private System.Windows.Forms.Button buttonCixis;
    }
}
