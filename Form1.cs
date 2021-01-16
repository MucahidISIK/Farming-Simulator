/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**	     	BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖĞRENCİ ADI............: Mücahid
**              ÖĞRENCİ NUMARASI.......: B181210111
**              DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace farmingSimulator
{
    public partial class Form1 : Form
    {
        // hesaplama islemlerinde kullanmak uzere degiskenler belirleniyor
        int zaman = 0; 
        int tavukYumurtasi = 0;
        int ordekYumurtasi = 0;
        int inekSutu = 0;
        int kecisutu = 0;
        int kasa = 0;

        //  kurucular yardimiyle deger atamasi yapiliyor
        Tavuk tavuk = new Tavuk(3000, 2);
        Ordek ordek = new Ordek(5000, 3);
        Inek inek = new Inek(8000, 8);
        Keci keci = new Keci(7000, 6);
        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // picture boxlarin boyut duzenlenmesi yapiliyor
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // imageler upload ediliyor
            pictureBox1.Image = Image.FromFile("tavuk.png");
            pictureBox2.Image = Image.FromFile("ordek.png");
            pictureBox3.Image = Image.FromFile("inek.png");
            pictureBox4.Image = Image.FromFile("keci.png");

            // ikon upload edliliyor
            this.Icon = new Icon("ikon.ico");

            // labellere gerekli bilgiler aktariliyor
            label15.Text = Convert.ToString(zaman);
            label11.Text = Convert.ToString(tavukYumurtasi);
            label12.Text = Convert.ToString(inekSutu);
            label13.Text = Convert.ToString(ordekYumurtasi);
            label14.Text = Convert.ToString(kecisutu);
            label16.Text = Convert.ToString(kasa);

            timer1.Interval = 1000; // zaman icin sayac - 1000ms yani 1 saniye aralikla calisacak
            timer1.Start(); // sayac baslatiliyor

            timer2.Interval = tavuk.YumurtlamaSuresi; // tavuk yumurtlama suresi icin sayac
            timer2.Start();

            timer3.Interval = inek.SutVermeSuresi;  // inek sut verme suresi icin sayac
            timer3.Start();

            timer4.Interval = ordek.YumurtlamaSuresi;  // ordek yumurtlamas suresi icin sayac
            timer4.Start();

            timer5.Interval = keci.SutVermeSuresi; // keci sut verme sureci icin sayac
            timer5.Start();

            timer6.Interval = 1000; // tavuk olumu ve ses dosyası calismasi icin gereken sayac
            timer6.Start();

            timer7.Interval = 1000; // ordek olumu ve ses dosyası calismasi icin gereken sayac
            timer7.Start();

            timer8.Interval = 1000; // inek olumu ve ses dosyası calismasi icin gereken sayac
            timer8.Start();

            timer9.Interval = 1000; // ordek olumu ve ses dosyası calismasi icin gereken sayac
            timer9.Start();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // zaman degiskeni her 1 saniyede 1 birim arttirilip labele tekrar yaziliyor
            zaman += 1;
            label15.Text = Convert.ToString(zaman);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // tavugun enerji seviyesinin 0 olup olmadigi yani olu veya canli oldugu kontrol ediliyor
            if (progressBar1.Value != 0)
            {
                // tavuk yumurtasi sayisi belli araliklarla arttirilip gerekli labele yaziliyor
                tavukYumurtasi += 1;
                label11.Text = Convert.ToString(tavukYumurtasi);
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // inegin enerji seviyesinin 0 olup olmadigi yani olu veya canli oldugu kontrol ediliyor
            if (progressBar3.Value != 0)
            {
                // inek sutu sayisi belli araliklarla arttirilip gerekli labele yaziliyor
                inekSutu += 1;
                label12.Text = Convert.ToString(inekSutu);
            }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            // ordegin enerji seviyesinin 0 olup olmadigi yani olu veya canli oldugu kontrol ediliyor
            if (progressBar2.Value != 0)
            {
                // ordek yumurtasi sayisi belli araliklarla arttirilip gerekli labele yaziliyor
                ordekYumurtasi += 1;
                label13.Text = Convert.ToString(ordekYumurtasi);
            }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            // kecinin enerji seviyesinin 0 olup olmadigi yani olu veya canli oldugu kontrol ediliyor
            if (progressBar4.Value != 0)
            {
                // keci sutu sayisi belli araliklarla arttirilip gerekli labele yaziliyor
                kecisutu += 1;
                label14.Text = Convert.ToString(kecisutu);
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  tavuk yumurtasi satisi icin gerekli islemler yapiliyor
            label16.Text = Convert.ToString(Convert.ToDouble(label16.Text) + (Convert.ToDouble(label11.Text)));
            tavukYumurtasi =0;
            label11.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  ordek yumurtasi satisi icin gerekli islemler yapiliyor
            label16.Text = Convert.ToString(Convert.ToDouble(label16.Text)+(Convert.ToDouble(label13.Text) * 3));
            ordekYumurtasi=0;
            label13.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // inek sutu satisi icin gerekli islemler yapiliyor
            label16.Text = Convert.ToString(Convert.ToDouble(label16.Text) + (Convert.ToDouble(label12.Text) * 5));
            inekSutu =0;
            label12.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // keci sutu satisi icin gerekli islemler yapiliyor
            label16.Text = Convert.ToString(Convert.ToDouble(label16.Text) + (Convert.ToDouble(label14.Text) * 8));
            kecisutu = 0;
            label14.Text = "0";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // yem verme islemi yani progress bar valuesinin 100 yapilmasi islemi gerceklestiriliyor
            if (progressBar1.Value > 0)// olu olup olmadigi kontrol ediliyor
            {
                progressBar1.Value = 100;
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // yem verme islemi yani progress bar valuesinin 100 yapilmasi islemi gerceklestiriliyor
            if (progressBar2.Value >0) // olu olup olmadigi kontrol ediliyor
            {
                progressBar2.Value = 100;
            }
            
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // yem verme islemi yani progress bar valuesinin 100 yapilmasi islemi gerceklestiriliyor
            if (progressBar3.Value > 0)// olu olup olmadigi kontrol ediliyor
            {
                progressBar3.Value = 100;
            }
        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // yem verme islemi yani progress bar valuesinin 100 yapilmasi islemi gerceklestiriliyor
            if (progressBar4.Value > 0)// olu olup olmadigi kontrol ediliyor
            {
                progressBar4.Value = 100;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            // her saniye belirlenen seviyede enerji azalimi gerceklestiriliyor
            if (progressBar1.Value >= tavuk.EnerjiTuketimi)
            {
                progressBar1.Value = tavuk.EnerjiAzalt(progressBar1.Value);
            }
            // enerji 0 olmasi durumunda olu olarak belirlenip ses dosyasi calistiriliyor ve timer durduruluyor
            if (progressBar1.Value == 0)
            {
                label17.Text = "ÖLÜ";

                SoundPlayer player = new SoundPlayer();
                string path = "tavuk.wav";
                player.SoundLocation = path;
                player.Play();
                timer6.Stop();
            }
            
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            // her saniye belirlenen seviyede enerji azalimi gerceklestiriliyor
            if (progressBar2.Value >= ordek.EnerjiTuketimi)
            {
                progressBar2.Value = ordek.EnerjiAzalt(progressBar2.Value);

            }
            else
            {
                progressBar2.Value = 0;
            }
            // enerji 0 olmasi durumunda olu olarak belirlenip ses dosyasi calistiriliyor ve timer durduruluyor
            if (progressBar2.Value == 0)
            {
                label18.Text = "ÖLÜ";
                SoundPlayer player = new SoundPlayer();
                string path = "ordek.wav";
                player.SoundLocation = path;
                player.Play();
                timer7.Stop();
            }
            
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            // her saniye belirlenen seviyede enerji azalimi gerceklestiriliyor
            if (progressBar3.Value >= inek.EnerjiTuketimi)
            {
                progressBar3.Value = inek.EnerjiAzalt(progressBar3.Value);
            }
            else
            {
                progressBar3.Value = 0;
            }
            // enerji 0 olmasi durumunda olu olarak belirlenip ses dosyasi calistiriliyor ve timer durduruluyor
            if (progressBar3.Value == 0)
            {
                label19.Text = "ÖLÜ";
                SoundPlayer player = new SoundPlayer();
                string path = "inek.wav";
                player.SoundLocation = path;
                player.Play();
                timer8.Stop();
            }
            
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            // her saniye belirlenen seviyede enerji azalimi gerceklestiriliyor
            if (progressBar4.Value >= keci.EnerjiTuketimi)
            {
                progressBar4.Value = keci.EnerjiAzalt(progressBar4.Value);
            }
            else
            {
                progressBar4.Value = 0;
            }
            // enerji 0 olmasi durumunda olu olarak belirlenip ses dosyasi calistiriliyor ve timer durduruluyor
            if (progressBar4.Value == 0)
            {
                label20.Text = "ÖLÜ";
                SoundPlayer player = new SoundPlayer();
                string path = "keci.wav";
                player.SoundLocation = path;
                player.Play();
                timer9.Stop();
            }
            
        }
    }
}
