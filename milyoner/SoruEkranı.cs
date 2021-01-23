using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim1MilyonSekerIster
{
    public partial class frmSoruEkranı : Form
    {
        int zaman = 30;
        int sorusayisi = 1;

        string[] sorular = new string[31];
        char[] cvplar = new char[31];
        string[] buton1 = new string[31];
        string[] buton2 = new string[31];
        string[] buton3 = new string[31];
        string[] buton4 = new string[31];
        int cvp = 0;
        Random rnd = new Random();
        public frmSoruEkranı()
        {
            InitializeComponent();

            sorular[0] = "Aşağıdaki dağlardan hangisi volkanik bir dağ değildir?";
            sorular[1] = "Türkiye'yi ağaçlandırmak ve erozyonla mücadele etmek olan kurulan Sivil Toplum Kuruluşu, aşağıdakilerden hangisidir?";
            sorular[2] = "Aşağıdakilerden hangisi Türkiye’nin komşusu olan bir ülke değildir?";
            sorular[3] = "Çinlilerin Hun, Tunguz ve Moğol akımlarını durdurmak için inşa ettiği yapı hangisidir?";
            sorular[4] = "Dünya İnsan Hakları Günü hangi gün kutlanır?";
            sorular[5] = "İstanbul hangi coğrafi bölgemizde yer almaktadır?";
            sorular[6] = "Türk tarihinin en ünlü mimarı kimdir?";
            sorular[7] = "Çocuk hakları günü hangi tarihte kutlanmaktadır?";
            sorular[8] = "Çanakkale Savaşı sırasında 215 kg’lık mermiyi tek başına kaldıran Türk askeri kimdir?";
            sorular[9] = "Duvara asılı bir haritanın sağı her zaman hangi yönü gösterir?";
            sorular[10] = "Aşağıdakilerden hangisi çocuk hastalığıdır?";
            sorular[11] = "Aşağıdakilerden hangisi toprak altında büyür?";
            sorular[12] = "Türk hanlarının yaşadığı çerge olarak da bilinen büyük ve süslü çadırın adı nedir?";
            sorular[13] = "Yön bulmak için aşağıdakilerden hangisi kullanılmaz?";
            sorular[14] = "İçerisinde yüksek oranda demir minerali bulunduran sebze hangisidir?";
            sorular[15] = "Aşağıdakilerden hangisi doğal ışık kaynağı değildir?";
            sorular[16] = "Mıknatıs aşağıdakilerden hangisini çeker?";
            sorular[17] = "Aşağıdaki hayvanlardan hangisi çöl ortamına daha dayanıklıdır?";
            sorular[18] = "Dünyanın yüzölçümü en büyük ülkesi hangisidir?";
            sorular[19] = "Aşağıdakilerden hangisi Dünyanın en yüksek dağıdır?";
            sorular[20] = "Dünyada en fazla hangi dil kullanılır?";
            sorular[21] = "Bazı aylarda 30, bazılarında ise 31 gün vardır; kaç ayda 28 gün vardır?";
            sorular[22] = "Sadece bir tek kibritiniz var, içinde bir gaz lambası, bir gaz sobası ve bir de mum bulunan karanlık ve soğuk bir odaya girdiniz… Önce hangisini yakarsınız? ";
            sorular[23] = "Mezarın başında bir kız ağlıyor. Mezarda yatanın annesi ağlayan kızın annesinin kayın validesi. Mezarda yatan, ağlayan kızın nesi olur? ";
            sorular[24] = "Çini işlemeciliğiyle ünlü ilimiz hangisidir?";
            sorular[25] = "3 çocuğum var. Birincisi benim yaşımın ilk rakamı yasındadır. İkincisi benim yaşımın ikinci rakamı yasındadır. Üçüncüsü bu iki rakamın toplamı yaşındadır. Hiçbirinin yaşı aynı olmadığına göre ve hepimizin yaşları toplamı 45 ise benim yaşım kaçtır? ";
            sorular[26] = "Adamın biri dikdörtgen biçiminde ve her cephesi güney manzaralı bir ev inşa ediyor.Evi kocaman bir ayı ziyaret ederse bu ayı ne renk olur?";
            sorular[27] = "Topkapı ya giderken yolda yedi karısı olan bir adamla tanıştım. Her kadın yedi çanta taşıyordu. Her çantada da yedi kedi vardı. Her kedinin de yedi yavrusu vardı. Kedi yavruları kediler çantalar kadınlar toplam kaç kişi Topkapı ya gidiyordur?  ";
            sorular[28] = "Milli Egemenlik ve Çocuk Bayramı hangi gündür";
            sorular[29] = "Milenyum kaç yıl demektir?";
            sorular[30] = "60'ın yarıma bölümüne çeyreğini eklersek kaç olur?";

            cvplar[0] = 'b';
            cvplar[1] = 'd';
            cvplar[2] = 'c';
            cvplar[3] = 'd';
            cvplar[4] = 'b';
            cvplar[5] = 'c';
            cvplar[6] = 'a';
            cvplar[7] = 'b';
            cvplar[8] = 'd';
            cvplar[9] = 'b';
            cvplar[10] = 'b';
            cvplar[11] = 'd';
            cvplar[12] = 'd';
            cvplar[13] = 'd';
            cvplar[14] = 'c';
            cvplar[15] = 'a';
            cvplar[16] = 'b';
            cvplar[17] = 'd';
            cvplar[18] = 'c';
            cvplar[19] = 'a';
            cvplar[20] = 'b';
            cvplar[21] = 'd';
            cvplar[22] = 'c';
            cvplar[23] = 'b';
            cvplar[24] = 'a';
            cvplar[25] = 'c';
            cvplar[26] = 'd';
            cvplar[27] = 'a';
            cvplar[28] = 'a';
            cvplar[29] = 'b';
            cvplar[30] = 'd';

            buton1[0] = "a) Erciyes";
            buton2[0] = "b) Toroslar";
            buton3[0] = "c) Ağrı Dağı";
            buton4[0] = "d) Nemrut Dağı";

            buton1[1] = "a) AFAD";
            buton2[1] = "b) TOBB";
            buton3[1] = "c) TEV";
            buton4[1] = "d) TEMA";

            buton1[2] = "a) Bulgaristan";
            buton2[2] = "b) Yunanistan";
            buton3[2] = "c) Norveç";
            buton4[2] = "d) İran";

            buton1[3] = "a) Çin Savunma Bakanlığı";
            buton2[3] = "b) Çin Sarayı";
            buton3[3] = "c) Çin Kalesi";
            buton4[3] = "d) Çin Seddi";

            buton1[4] = "a) 27 Aralık";
            buton2[4] = "b) 10 Aralık";
            buton3[4] = "c) 27 Nisan";
            buton4[4] = "d) 1 Eylül";

            buton1[5] = "a) Ege Bölgesi";
            buton2[5] = "b) Karadeniz Bölgesi";
            buton3[5] = "c) Marmara Bölgesi";
            buton4[5] = "d) Akdeniz Bölgesi";

            buton1[6] = "a) Mimar Sinan";
            buton2[6] = "b) Mimar Kemalettin";
            buton3[6] = "c) Evim Şahane Selim Bey";
            buton4[6] = "d) Mimar Hayrettin";

            buton1[7] = "a) 23 Nisan";
            buton2[7] = "b) 20 Kasım";
            buton3[7] = "c) 29 Ekim";
            buton4[7] = "d) 24 Ocak";

            buton1[8] = "a) Ferhat Yüzbaşı";
            buton2[8] = "b) Mehmet Binbaşı";
            buton3[8] = "c) Ahmet Onbaşı";
            buton4[8] = "d) Seyit Onbaşı";

            buton1[9] = "a) Kuzey";
            buton2[9] = "b) Doğu";
            buton3[9] = "c) Güney";
            buton4[9] = "d) Batı";

            buton1[10] = "a) Nezle";
            buton2[10] = "b) Kızamık";
            buton3[10] = "c) Alzheimer";
            buton4[10] = "d) Romatizma";

            buton1[11] = "a) Domates";
            buton2[11] = "b) Salatalık";
            buton3[11] = "c) Elma";
            buton4[11] = "d) Havuç";
            
            buton1[12] = "a) Divan";
            buton2[12] = "b) Çadır";
            buton3[12] = "c) Kümbet";
            buton4[12] = "d) Otağ";

            buton1[13] = "a) Yosun";
            buton2[13] = "b) Karınca Yuvaları";
            buton3[13] = "c) Kutup Yıldızı";
            buton4[13] = "d) Ay";

            buton1[14] = "a) Pırasa";
            buton2[14] = "b) Biber";
            buton3[14] = "c) Ispanak";
            buton4[14] = "d) Patlıcan";

            buton1[15] = "a) Mum";
            buton2[15] = "b) Güneş";
            buton3[15] = "c) Ateş Böceği";
            buton4[15] = "d) Yıldızlar";

            buton1[16] = "a) Tahta";
            buton2[16] = "b) İğne";
            buton3[16] = "c) Kola Şişesi";
            buton4[16] = "d) Cam Bardak";

            buton1[17] = "a) Aslan";
            buton2[17] = "b) Balina";
            buton3[17] = "c) Ayı";
            buton4[17] = "d) Deve";

            buton1[18] = "a) Brezilya";
            buton2[18] = "b) Çin";
            buton3[18] = "c) Rusya";
            buton4[18] = "d) Hindistan";

            buton1[19] = "a) Everest Tepesi";
            buton2[19] = "b) K2 Dağı";
            buton3[19] = "c) Kançençunga Dağı";
            buton4[19] = "d) Lhotse Dağı";

            buton1[20] = "a) İngilizce";
            buton2[20] = "b) Çince";
            buton3[20] = "c) İspanyolca";
            buton4[20] = "d) Türkçe";

            buton1[21] = "a) 8";
            buton2[21] = "b) 6";
            buton3[21] = "c) 1";
            buton4[21] = "d) 12";

            buton1[22] = "a) Gaz Lambası";
            buton2[22] = "b) Mum";
            buton3[22] = "c) Kibrit";
            buton4[22] = "d) Gaz Sobası";

            buton1[23] = "a) Teyzesi ";
            buton2[23] = "b) Halası";
            buton3[23] = "c) Dayısı";
            buton4[23] = "d) Yengesi";

            buton1[24] = "a) Kütahya";
            buton2[24] = "b) Bursa";
            buton3[24] = "c) Ankara";
            buton4[24] = "d) İzmit";

            buton1[25] = "a) 23";
            buton2[25] = "b) 24";
            buton3[25] = "c) 27";
            buton4[25] = "d) 28";

            buton1[26] = "a) Siyah";
            buton2[26] = "b) Kahverengi";
            buton3[26] = "c) Gri";
            buton4[26] = "d) Beyaz";

            buton1[27] = "a) 1";
            buton2[27] = "b) 161.620.914";
            buton3[27] = "c) 2.262.692.796";
            buton4[27] = "d) 4.525.385.592";

            buton1[28] = "a) 23 Nisan";
            buton2[28] = "b) 29 Ekim";
            buton3[28] = "c) 10 Kasım";
            buton4[28] = "d) 30 Ağustos";

            buton1[29] = "a) 100 yıl";
            buton2[29] = "b) 1000 yıl";
            buton3[29] = "c) 10 yıl";
            buton4[29] = "d) 12 yıl";

            buton1[30] = "a) 135";
            buton2[30] = "b) 17";
            buton3[30] = "c) 150";
            buton4[30] = "d) 2.5";

            bilince();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        void sekeragaci()
        {

            if (sorusayisi == 1)
                lbl1.BackColor = Color.Orange;
            if (sorusayisi == 2)
                lbl2.BackColor = Color.Orange;
            if (sorusayisi == 3)
                lbl3.BackColor = Color.Orange;
            if (sorusayisi == 4)
                lbl4.BackColor = Color.Orange;
            if (sorusayisi == 5)
                lbl5.BackColor = Color.Orange;
            if (sorusayisi == 6)
                lbl6.BackColor = Color.Orange;
            if (sorusayisi == 7)
                lbl7.BackColor = Color.Orange;
            if (sorusayisi == 8)
                lbl8.BackColor = Color.Orange;
            if (sorusayisi == 9)
                lbl9.BackColor = Color.Orange;
            if (sorusayisi == 10)
                lbl10.BackColor = Color.Orange;
            if (sorusayisi == 11)
                lbl11.BackColor = Color.Orange;
            if (sorusayisi == 12)
                lbl12.BackColor = Color.Orange;
        }

        private void btnCekil_Click(object sender, EventArgs e)
        {
            if (sorusayisi == 2)
                MessageBox.Show("Ödülünüz 500 Şeker");
            if (sorusayisi == 3)
                MessageBox.Show("Ödülünüz 1.000 Şeker");
            if (sorusayisi == 4)
                MessageBox.Show("Ödülünüz 2.000 Şeker");
            if (sorusayisi == 5)
                MessageBox.Show("Ödülünüz 3.000 Şeker");
            if (sorusayisi == 6)
                MessageBox.Show("Ödülünüz 5.000 Şeker");
            if (sorusayisi == 7)
                MessageBox.Show("Ödülünüz 7.500 Şeker");
            if (sorusayisi == 8)
                MessageBox.Show("Ödülünüz 15.000 Şeker");
            if (sorusayisi == 9)
                MessageBox.Show("Ödülünüz 30.000 Şeker");
            if (sorusayisi == 10)
                MessageBox.Show("Ödülünüz 60.000 Şeker");
            if (sorusayisi == 11)
                MessageBox.Show("Ödülünüz 125.000 Şeker");
            if (sorusayisi == 12)
                MessageBox.Show("Ödülünüz 250.000 Şeker");
            Application.Restart();
        }
        void sorusayisiniartir()
        {
            sorusayisi++;
            
            if (sorusayisi>7)
            {
                tmrZaman.Enabled = false;
                tmrZaman.Stop();
                lblZaman.Visible = false;
                btnCiftCevap.Visible = true;
            }
            if (sorusayisi == 12)
            {
                MessageBox.Show("Tebrikler 1.000.000 Şeker Kazandınız");
                Application.Restart();
            }

        }
        void kaybet()
        {
            if (sorusayisi == 1 || sorusayisi == 2)
            {
                MessageBox.Show("Elendiniz... Doğru Cevap Şıkkı "+cvplar[cvp]);
            }
            else if (sorusayisi == 3 || sorusayisi == 4 || sorusayisi == 5 || sorusayisi == 6)
            {
                MessageBox.Show("1.000 Şeker kazandınız... Doğru Cevap Şıkkı " + cvplar[cvp]);
            }
            else if (sorusayisi == 7 || sorusayisi == 8 || sorusayisi == 9 || sorusayisi == 10 || sorusayisi == 11 || sorusayisi == 12)
            {
                MessageBox.Show("15.000 Şeker kazandınız... Doğru Cevap Şıkkı " + cvplar[cvp]);
            }
            Application.Restart();
        }

        public int rastgele()
        {
            int ara = 0;
            int sayac = 0;
            int[] dizi = new int[31];
            dizi[sayac] = ara;
            don:
            cvp = rnd.Next(0, 31);
            if (dizi.Contains(cvp))
            {
                goto don;
            }
            else
            {
                dizi[sayac] = cvp;
                sayac++;
                return cvp;
            }
            
            
        }
        void butongetir()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;

        }
        void bilince()
        {
            butongetir();
            rastgele();
            txtSoru.Text = sorular[cvp].ToUpper();
            btn1.Text = buton1[cvp].ToUpper();
            btn2.Text = buton2[cvp].ToUpper();
            btn3.Text = buton3[cvp].ToUpper();
            btn4.Text = buton4[cvp].ToUpper();
            if (sorusayisi == 2)
            {
                btnCekil.Visible = true;
            }
            
        }

        void cvpkontrol(char harf)
        {

            if (cvplar[cvp] == harf)
            {
                zaman = 30;
                tmrZaman.Stop();
                MessageBox.Show("Doğru Cevap Verdiniz");
                tmrZaman.Start();
                bilince();
                sekeragaci();
            }
            else
            {
                if (ccvp==true && kullan==true)
                {
                    ciftcevap(harf);
                } else
                    kaybet();
            }
                

            sorusayisiniartir();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Green;
            cvpkontrol('a');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Green;
            cvpkontrol('b');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Green;
            cvpkontrol('c');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Green;
            cvpkontrol('d');
        }

        private void btnYuzde50_Click(object sender, EventArgs e)
        {
            if (cvplar[cvp] == 'a')
            {
                btn2.Visible = false;
                btn4.Visible = false;
            }
            else if (cvplar[cvp] == 'b')
            {
                btn1.Visible = false;
                btn3.Visible = false;
            }
            else if (cvplar[cvp] == 'c')
            {
                btn2.Visible = false;
                btn4.Visible = false;
            }
            else if (cvplar[cvp] == 'd')
            {
                btn1.Visible = false;
                btn2.Visible = false;
            }
            btnYuzde50.Enabled = false;
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
                zaman--;
                lblZaman.Text = zaman.ToString();
                if (zaman == 0)
                {
                    tmrZaman.Enabled = false;
                    MessageBox.Show("Süreniz doldu,Kaybettiniz");
                    Application.Exit();
                }
           
            
        }
        bool ccvp = false; bool kullan = false;
        void ciftcevap(char gelensecenek)
        {
            
            if (gelensecenek == 'a')
                btn1.Hide();
            else if (gelensecenek == 'b')
                btn2.Hide();
            else if (gelensecenek == 'c')
                btn3.Hide();
            else if (gelensecenek == 'd')
                btn4.Hide();
            
        }

        private void btnCiftCevap_Click(object sender, EventArgs e)
        {
            ccvp = true;
            kullan = true;
            btnCiftCevap.Enabled = kullan;
            btnCiftCevap.Visible = false;
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            tmrZaman.Stop(); 
            btnTelefon.Visible = false;
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101 - a);
            int c = rnd.Next(1, (101 - (a + b)));
            int d = rnd.Next(1, (101 - (a + b + c)));
            frmTelefon telefon = new frmTelefon();
            telefon.btnA.Height = a;
            telefon.btnB.Height = b;
            telefon.btnC.Height = c;
            telefon.btnD.Height = d;
            telefon.btnA.Text = a.ToString();
            telefon.btnB.Text = b.ToString();
            telefon.btnC.Text = c.ToString();
            telefon.btnD.Text = d.ToString();
            telefon.Show();
        }

        private void btnSeyirci_Click(object sender, EventArgs e)
        {
            tmrZaman.Stop();
            btnSeyirci.Visible = false;
            int a = rnd.Next(1, 101);
            int b = rnd.Next(1, 101 - a);
            int c = rnd.Next(1, (101 - (a + b)));
            int d = rnd.Next(1, (101 - (a + b + c)));
            frmSeyirci seyirci = new frmSeyirci();
            seyirci.btnA.Height = a;
            seyirci.btnB.Height = b;
            seyirci.btnC.Height = c;
            seyirci.btnD.Height = d;
            seyirci.btnA.Text = a.ToString();
            seyirci.btnB.Text = b.ToString();
            seyirci.btnC.Text = c.ToString();
            seyirci.btnD.Text = d.ToString();
            seyirci.Show();
        }
       
    }
}
