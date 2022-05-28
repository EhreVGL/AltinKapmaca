using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AltinKapmaca
{
    public partial class Form1 : Form
    {
        int[] tahta_uzunlugu = new int[2];
        public int[,] tahta;
        int altin_orani;
        int toplam_altin = 0;
        int gizli_altin_orani;
        int toplam_gizli_altin = 0;
        int baslangic_altin_miktari;
        int hamle_max_hareket_miktari;
        int[] oyuncu_hamle_maliyeti = new int[4];
        int[] oyuncu_hedef_maliyeti = new int[4];
        Bitmap[] image_button = new Bitmap[5];
        Button[,] oyun_masasi;
        int gecikme = 200;
        int gizli_altin_total;
        Oyun[] oyuncu = new Oyun[4];

        public Form1()
        {

            InitializeComponent();
            altin_oran_listbox.SelectedIndex = 1;
            gizlialtin_oran_listbox.SelectedIndex = 0;
            bas_altin_mik_listbox.SelectedIndex = 1;
            hamle_max_har_mik_listbox.SelectedIndex = 2;
            oyuncu1_hamle_listbox.SelectedIndex= 0;
            oyuncu2_hamle_listbox.SelectedIndex = 0;
            oyuncu3_hamle_listbox.SelectedIndex = 0;
            oyuncu4_hamle_listbox.SelectedIndex = 0;
            oyuncu1_hedef_listbox.SelectedIndex = 0;
            oyuncu2_hedef_listbox.SelectedIndex = 1;
            oyuncu3_hedef_listbox.SelectedIndex = 2;
            oyuncu4_hedef_listbox.SelectedIndex = 3;
        }

        private void basla_Click(object sender, EventArgs e)
        {
            int[,] tahta_deger = new int[tahta_uzunlugu[0], tahta_uzunlugu[1]];
            // TAHTA UZUNLUĞUNUN DEĞERLERİNİ AYARLARDAN ÇEKİYOR.
            tahta_uzunlugu[0] = int.Parse(satir_sayisi_txtbox.Text);
            tahta_uzunlugu[1] = int.Parse(sutun_sayisi_txtbox.Text);
            altin_orani = int.Parse(altin_oran_listbox.SelectedItem.ToString());
            gizli_altin_orani = int.Parse(gizlialtin_oran_listbox.SelectedItem.ToString());
            baslangic_altin_miktari = int.Parse(bas_altin_mik_listbox.SelectedItem.ToString());
            hamle_max_hareket_miktari = int.Parse(hamle_max_har_mik_listbox.SelectedItem.ToString());
            oyuncu_hamle_maliyeti[0] = int.Parse(oyuncu1_hamle_listbox.SelectedItem.ToString());
            oyuncu_hamle_maliyeti[1] = int.Parse(oyuncu2_hamle_listbox.SelectedItem.ToString());
            oyuncu_hamle_maliyeti[2] = int.Parse(oyuncu3_hamle_listbox.SelectedItem.ToString());
            oyuncu_hamle_maliyeti[3] = int.Parse(oyuncu4_hamle_listbox.SelectedItem.ToString());
            oyuncu_hedef_maliyeti[0] = int.Parse(oyuncu1_hamle_listbox.SelectedItem.ToString());
            oyuncu_hedef_maliyeti[1] = int.Parse(oyuncu2_hamle_listbox.SelectedItem.ToString());
            oyuncu_hedef_maliyeti[2] = int.Parse(oyuncu3_hamle_listbox.SelectedItem.ToString());
            oyuncu_hedef_maliyeti[3] = int.Parse(oyuncu4_hamle_listbox.SelectedItem.ToString());

            image_button[0] = new Bitmap(AltinKapmaca.Properties.Resources.altin);
            image_button[1] = new Bitmap(AltinKapmaca.Properties.Resources.player1);
            image_button[2] = new Bitmap(AltinKapmaca.Properties.Resources.player2);
            image_button[3] = new Bitmap(AltinKapmaca.Properties.Resources.player3);
            image_button[4] = new Bitmap(AltinKapmaca.Properties.Resources.player4);


            tahta_deger = oyun_masasi_yarat();
            Size = new Size(450 + tahta_uzunlugu[0] * 31, 150+ tahta_uzunlugu[1] * 31);

            oyun_basladi(tahta_deger);

            panel3.Visible = true;
        }

        private void ayar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ayar_kaydet_Click(object sender, EventArgs e)
        {

            panel2.Visible = false;
        }

        private int[,] oyun_masasi_yarat()
        {
            int buton_bosluk = 1;
            Size buton_size = new Size(30,30);
            Point buton_konum = new Point();
            oyun_masasi = new Button[tahta_uzunlugu[0], tahta_uzunlugu[1]];
            /************************************************/
            int[,] tahta_deger = new int[tahta_uzunlugu[0], tahta_uzunlugu[1]];
            int i, j;


            // Oyun tahtasının saf halini oluşturmaya yarar. Arayüze butonları ekler.
            for (i = 0; i < tahta_uzunlugu[0]; i++)
            {
                buton_konum.Y = 50 + i * buton_bosluk + i * buton_size.Height;
                for (j = 0; j < tahta_uzunlugu[1]; j++)
                {
                    oyun_masasi[i, j] = new Button();
                    oyun_masasi[i, j].Size = buton_size;
                    buton_konum.X = 50 + j * buton_bosluk + j * buton_size.Width;
                    oyun_masasi[i,j].Location = buton_konum;
                    panel3.Controls.Add(oyun_masasi[i, j]);
                }
            }
            // Oyun tahtasındaki butonların resim değerlerini belirler.
            // Oyuncuların başlangıç konumlarını verir.
            for (i = 0; i < tahta_deger.GetLength(0); i++)
            {
                for (j = 0; j < tahta_deger.GetLength(1); j++)
                {
                    if (i == 0 && j == 0) 
                    { 
                        tahta_deger[i, j] = 1;
                        oyun_masasi[i, j].Image = image_button[1];
                    }
                    if (i == 0 && j == tahta_deger.GetLength(1)-1) 
                    { 
                        tahta_deger[i, j] = 2;
                        oyun_masasi[i, j].Image = image_button[2];

                    }
                    if (i == tahta_deger.GetLength(0)-1 && j == 0) 
                    { 
                        tahta_deger[i, j] = 3;
                        oyun_masasi[i, j].Image = image_button[3];
                    }
                    if (i == tahta_deger.GetLength(0)-1 && j == tahta_deger.GetLength(1)-1) 
                    { 
                        tahta_deger[i, j] = 4;
                        oyun_masasi[i, j].Image = image_button[4];
                    }
                }
            }
            // Altınları rastgele dağıtır ve konumlarını belirler.
            Random random = new Random();
            int toplam_buton = tahta_deger.GetLength(0) * tahta_deger.GetLength(1);
            toplam_altin = toplam_buton * altin_orani / 100;
            toplam_gizli_altin = toplam_altin * gizli_altin_orani / 100;
            int sayac_gizli_altin = 0;
            int satir;
            int sutun;
            i = 0;
            while (i < toplam_altin)
            {
                satir = random.Next(0, tahta_deger.GetLength(0));
                sutun = random.Next(0, tahta_deger.GetLength(1));
                if (tahta_deger[satir, sutun] != 0)
                {
                    continue;
                }
                else
                {
                    if (sayac_gizli_altin != toplam_gizli_altin)
                    {
                        tahta_deger[satir, sutun] = random.Next(0, 4) + 9;
                        sayac_gizli_altin++;
                    }
                    else
                    {
                        tahta_deger[satir, sutun] = random.Next(0, 4) + 5;
                        oyun_masasi[satir, sutun].Image = image_button[0];
                    }
                    i++;
                }
            }
            return tahta_deger;
        }
        
        //********************************************************************************************************************************************************
         private async Task<(int[,], int[,])> Hedefe_gitme(int[,] altin_sorgu, int[,] tahta_degerleri, int sayac)
         {
            int i;
            // Oyuncuyu adım adım hedefe götürme.
            // satır düzleminde
            if (oyuncu[sayac].konum[0] != oyuncu[sayac].hedef[0])
            {
                for (i = 0; i < hamle_max_hareket_miktari; i++)
                {
                    if (oyuncu[sayac].konum[0] > oyuncu[sayac].hedef[0])
                    {
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 2)
                        {
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                            if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 9))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 5;

                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 10))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 6;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 11))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 7;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 12))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 8;
                            }
                        }
                        else if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 1)
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                        }
                        else
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = null;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                        oyuncu[sayac].konum[0] -= 1;
                        oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[sayac+1];
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] != 2)
                        {
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = sayac + 1;
                        }
                        await Task.Delay(gecikme);
                    }
                    else if (oyuncu[sayac].konum[0] < oyuncu[sayac].hedef[0])
                    {
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 2)
                        {
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                            if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 9))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 5;

                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 10))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 6;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 11))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 7;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 12))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 8;
                            }
                        }
                        else if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 1)
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                        }
                        else
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = null;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                        oyuncu[sayac].konum[0] += 1;
                        oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[sayac+1];
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] != 2)
                        {
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = sayac + 1;

                        }

                        await Task.Delay(gecikme);
                    }
                    if (oyuncu[sayac].konum[0] == oyuncu[sayac].hedef[0])
                    {
                        break;
                    }
                }
                oyuncu[sayac].para -= oyuncu_hamle_maliyeti[sayac];
            }
            //sütun düzleminde
            else if (oyuncu[sayac].konum[1] != oyuncu[sayac].hedef[1])
            {
                for (i = 0; i < hamle_max_hareket_miktari; i++)
                {
                    if (oyuncu[sayac].konum[1] > oyuncu[sayac].hedef[1])
                    {
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 2)
                        {
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                            if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 9))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 5;

                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 10))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 6;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 11))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 7;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 12))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 8;
                            }
                        }
                        else if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 1)
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                        }
                        else
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = null;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                        oyuncu[sayac].konum[1] -= 1;
                        oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[sayac + 1];
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] != 2)
                        {
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = sayac + 1;
                        }
                        await Task.Delay(gecikme);
                    }
                    else if (oyuncu[sayac].konum[1] < oyuncu[sayac].hedef[1])
                    {
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 2)
                        {
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                            if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 9))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 5;

                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 10))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 6;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 11))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 7;
                            }
                            else if ((tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 12))
                            {
                                tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 8;
                            }
                        }
                        else if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] == 1)
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[0];
                        }
                        else
                        {
                            oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = null;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                        oyuncu[sayac].konum[1] += 1;
                        oyun_masasi[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]].Image = image_button[sayac + 1];
                        if (altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] != 2)
                        {
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = sayac + 1;
                        }
                        await Task.Delay(gecikme);
                    }
                    if (oyuncu[sayac].konum[1] == oyuncu[sayac].hedef[1])
                    {
                        break;
                    }
                }
                oyuncu[sayac].para -= oyuncu_hamle_maliyeti[sayac];
            }
            return (altin_sorgu, tahta_degerleri);
        }

        //********************************************************************************************************************************************************

        private async void oyun_basladi(int[,] tahta_degerleri)
        {
            // Butonların durumlarını belirleyen değişken.
            int[,] altin_sorgu = new int[tahta_uzunlugu[0],tahta_uzunlugu[1]];
            int i,j,sayac;
            // 4 Oyuncuyu oluşturduğumuz nokta. Başlangıç konumları ve hedef konumları belirsiz.

            for (i = 0; i < 4; i++)
            {
                oyuncu[i] = new Oyun();
                oyuncu[i].id = i;
                oyuncu[i].para = baslangic_altin_miktari;

                if(i == 0)
                {
                    oyuncu[i].konum[0] = 0;
                    oyuncu[i].konum[1] = 0;
                    oyuncu[i].hedef[0] = 0;
                    oyuncu[i].hedef[1] = 0;
                }
                else if(i == 1)
                {
                    oyuncu[i].konum[0] = 0;
                    oyuncu[i].konum[1] = tahta_uzunlugu[1]-1;
                    oyuncu[i].hedef[0] = 0;
                    oyuncu[i].hedef[1] = tahta_uzunlugu[1]-1;
                }
                else if(i == 2)
                {
                    oyuncu[i].konum[0] = tahta_uzunlugu[0]-1;
                    oyuncu[i].konum[1] = 0;
                    oyuncu[i].hedef[0] = tahta_uzunlugu[0]-1;
                    oyuncu[i].hedef[1] = 0;
                }
                else if(i == 3)
                {
                    oyuncu[i].konum[0] = tahta_uzunlugu[0]-1;
                    oyuncu[i].konum[1] = tahta_uzunlugu[1]-1;
                    oyuncu[i].hedef[0] = tahta_uzunlugu[0]-1;
                    oyuncu[i].hedef[1] = tahta_uzunlugu[1]-1;
                }
            }

            for (i = 0; i < tahta_uzunlugu[0]; i++)
            {
                for (j = 0; j < tahta_uzunlugu[1]; j++)
                {
                    if(tahta_degerleri[i,j] == 0 || tahta_degerleri[i, j] == 1 || tahta_degerleri[i, j] == 2 || tahta_degerleri[i, j] == 3 || tahta_degerleri[i, j] == 4)
                    {
                        altin_sorgu[i, j] = 0;
                    }
                    else if(tahta_degerleri[i, j] == 5 || tahta_degerleri[i, j] == 6 || tahta_degerleri[i, j] == 7 || tahta_degerleri[i, j] == 8)
                    {
                        oyun_masasi[i, j].BackColor = Color.IndianRed;
                        altin_sorgu[i, j] = 1;
                    }
                    else if (tahta_degerleri[i, j] == 9 || tahta_degerleri[i, j] == 10 || tahta_degerleri[i, j] == 11 || tahta_degerleri[i, j] == 12)
                    {
                        oyun_masasi[i, j].BackColor = Color.Gray;
                        altin_sorgu[i, j] = 2;
                    }
                }
            }
            int altin_var=0;
            int[] altin_var_konum = new int[2];
            double enkisa = 100000;
            double enkarli = 0;
            double[] oyuncu4_casus = new double[4];
            int[] gizli_altin_sayac = new int[2];
            int ucuncu_oyuncu_sayac = 0;
            int[] oyuncu_kaybetme = new int[4] {0,0,0,0};
            int bitis_oyuncu_para = 4;
            int bitis_tahta = tahta_uzunlugu[0] * tahta_uzunlugu[1];
            // Oyunun oynanacağı yer olacak.
            while (true)
            {
                await Task.Delay(gecikme*2);
                for (sayac = 0; sayac < 4; sayac++)
                {
                    //Sıra 1. Oyuncuda ise
                    if(oyuncu[sayac].id == 0)
                    {
                        // Hedefteki konumda altın yoksa.
                        if (altin_sorgu[oyuncu[sayac].hedef[0],oyuncu[sayac].hedef[1]] != 1)
                        {
                            // Yeni altın hedefi belirleme.
                            for (i = 0; i < altin_sorgu.GetLength(0); i++)
                            {
                                for (j = 0; j < altin_sorgu.GetLength(1); j++)
                                {
                                    if(altin_sorgu[i,j] == 1)
                                    {
                                        if(Math.Sqrt(Math.Pow((i-oyuncu[sayac].konum[0]),2) + Math.Pow((j-oyuncu[sayac].konum[1]),2)) < enkisa)
                                        {
                                            enkisa = Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2));
                                            oyuncu[sayac].hedef[0] = i;
                                            oyuncu[sayac].hedef[1] = j;
                                        }
                                    }
                                }
                            }
                            enkisa = 100000;
                            oyuncu[sayac].para -= oyuncu_hedef_maliyeti[0];
                        }
                        if(oyuncu[sayac].para <= 0)
                        {
                            oyuncu_kaybetme[sayac] = 1;
                        }
                        else
                        {
                            (altin_sorgu, tahta_degerleri) = await Hedefe_gitme(altin_sorgu, tahta_degerleri, sayac);
                        }
                        
                        //oyuncu hedefe vardıysa hedefteki para kadar para ekle.
                        if(oyuncu[sayac].konum[0] == oyuncu[sayac].hedef[0] && oyuncu[sayac].konum[1] == oyuncu[sayac].hedef[1])
                        {
                            oyuncu[sayac].para += (tahta_degerleri[oyuncu[sayac].konum[0],oyuncu[sayac].konum[1]] % 5) * 5 + 5;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                    }

                    //Sıra 2. Oyuncuda ise
                    if (oyuncu[sayac].id == 1)
                    {
                        // Hedefteki konumda altın yoksa.
                        if (altin_sorgu[oyuncu[sayac].hedef[0], oyuncu[sayac].hedef[1]] != 1)
                        {
                            // Yeni altın hedefi belirleme.
                            for (i = 0; i < altin_sorgu.GetLength(0); i++)
                            {
                                for (j = 0; j < altin_sorgu.GetLength(1); j++)
                                {
                                    if (altin_sorgu[i, j] == 1)
                                    {
                                        if (((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[sayac]) > enkarli)
                                        {
                                            enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[sayac]);
                                            oyuncu[sayac].hedef[0] = i;
                                            oyuncu[sayac].hedef[1] = j;
                                        }
                                    }
                                }
                            }
                            enkarli = 0;
                            oyuncu[sayac].para -= oyuncu_hedef_maliyeti[1];
                        }
                        // Oyuncuyu adım adım hedefe götürme.
                        if (oyuncu[sayac].para <= 0)
                        {
                            oyuncu_kaybetme[sayac] = 1;
                        }
                        else
                        {
                            (altin_sorgu, tahta_degerleri) = await Hedefe_gitme(altin_sorgu, tahta_degerleri, sayac);
                        }
                        //oyuncu hedefe vardıysa hedefteki para kadar para ekle.
                        if (oyuncu[sayac].konum[0] == oyuncu[sayac].hedef[0] && oyuncu[sayac].konum[1] == oyuncu[sayac].hedef[1])
                        {
                            oyuncu[sayac].para += (tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] % 5) * 5 + 5;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                    }

                    // Sıra 3. oyuncuda ise
                    if (oyuncu[sayac].id == 2)
                    {
                        // Hedefteki konumda altın yoksa.
                        if (altin_sorgu[oyuncu[sayac].hedef[0], oyuncu[sayac].hedef[1]] != 1)
                        {
                            // Yeni altın hedefi belirleme.
                            
                            for(ucuncu_oyuncu_sayac = 0; ucuncu_oyuncu_sayac < 2; ucuncu_oyuncu_sayac++)
                            {
                                for (i = 0; i < altin_sorgu.GetLength(0); i++)
                                {
                                    for (j = 0; j < altin_sorgu.GetLength(1); j++)
                                    {
                                        if (altin_sorgu[i, j] == 2)
                                        {
                                            if (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) < enkisa)
                                            {
                                                enkisa = Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2));
                                                gizli_altin_sayac[0] = i;
                                                gizli_altin_sayac[1] = j;
                                            }
                                        }
                                    }
                                }
                                
                                gizli_altin_total++;
                                if(gizli_altin_total > toplam_gizli_altin)
                                {
                                    break;
                                }
                                else
                                {
                                    altin_sorgu[gizli_altin_sayac[0], gizli_altin_sayac[1]] = 1;
                                    oyun_masasi[gizli_altin_sayac[0], gizli_altin_sayac[1]].Image = image_button[0];
                                    if ((tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] == 9))
                                    {
                                        tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] = 5;
                                    }
                                    else if ((tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] == 10))
                                    {
                                        tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] = 6;
                                    }
                                    else if ((tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] == 11))
                                    {
                                        tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] = 7;
                                    }
                                    else if ((tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] == 12))
                                    {
                                        tahta_degerleri[gizli_altin_sayac[0], gizli_altin_sayac[1]] = 8;
                                    }
                                }
                                enkisa = 100000;
                            }

                            for (i = 0; i < altin_sorgu.GetLength(0); i++)
                            {
                                for (j = 0; j < altin_sorgu.GetLength(1); j++)
                                {
                                    if (altin_sorgu[i, j] == 1)
                                    {
                                        if (((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[sayac]) > enkarli)
                                        {
                                            enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[sayac]);
                                            oyuncu[sayac].hedef[0] = i;
                                            oyuncu[sayac].hedef[1] = j;
                                        }
                                    }
                                }
                            }
                            enkarli = 0;
                            oyuncu[sayac].para -= oyuncu_hedef_maliyeti[2];
                        }

                        // Oyuncuyu adım adım hedefe götürme.
                        if (oyuncu[sayac].para <= 0)
                        {
                            oyuncu_kaybetme[sayac] = 1;
                        }
                        else
                        {
                            (altin_sorgu, tahta_degerleri) = await Hedefe_gitme(altin_sorgu, tahta_degerleri, sayac);
                        }
                        //oyuncu hedefe vardıysa hedefteki para kadar para ekle.
                        if (oyuncu[sayac].konum[0] == oyuncu[sayac].hedef[0] && oyuncu[sayac].konum[1] == oyuncu[sayac].hedef[1])
                        {
                            oyuncu[sayac].para += (tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] % 5) * 5 + 5;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                    }

                    // Sıra 4. oyuncuda ise
                    if (oyuncu[sayac].id == 3)
                    {
                        // Hedefteki konumda altın yoksa.
                        if (altin_sorgu[oyuncu[sayac].hedef[0], oyuncu[sayac].hedef[1]] != 1)
                        {
                            // Yeni altın hedefi belirleme.
                            for (i = 0; i < altin_sorgu.GetLength(0); i++)
                            {
                                for (j = 0; j < altin_sorgu.GetLength(1); j++)
                                {
                                    if (altin_sorgu[i, j] == 1)
                                    {
                                        if (((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[3]) > enkarli)
                                        {
                                            oyuncu4_casus[3] = Math.Sqrt(Math.Pow((i - oyuncu[3].konum[0]), 2) + Math.Pow((j - oyuncu[3].konum[1]), 2));
                                            if (i == oyuncu[0].hedef[0] && j == oyuncu[0].hedef[1])
                                            {
                                                oyuncu4_casus[0] = Math.Sqrt(Math.Pow((i - oyuncu[0].konum[0]), 2) + Math.Pow((j - oyuncu[0].konum[1]), 2));
                                                if (oyuncu4_casus[3] < oyuncu4_casus[0])
                                                {
                                                    enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[3]);
                                                    oyuncu[3].hedef[0] = i;
                                                    oyuncu[3].hedef[1] = j;
                                                }
                                            }
                                            else if (i == oyuncu[1].hedef[0] && j == oyuncu[1].hedef[1])
                                            {
                                                oyuncu4_casus[1] = Math.Sqrt(Math.Pow((i - oyuncu[1].konum[0]), 2) + Math.Pow((j - oyuncu[1].konum[1]), 2));
                                                if (oyuncu4_casus[3] < oyuncu4_casus[1])
                                                {
                                                    enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[3]);
                                                    oyuncu[3].hedef[0] = i;
                                                    oyuncu[3].hedef[1] = j;
                                                }
                                            }
                                            else if (i == oyuncu[2].hedef[0] && j == oyuncu[2].hedef[1])
                                            {
                                                oyuncu4_casus[2] = Math.Sqrt(Math.Pow((i - oyuncu[2].konum[0]), 2) + Math.Pow((j - oyuncu[2].konum[1]), 2));
                                                if (oyuncu4_casus[3] < oyuncu4_casus[2])
                                                {
                                                    enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[3]);
                                                    oyuncu[3].hedef[0] = i;
                                                    oyuncu[3].hedef[1] = j;
                                                }
                                            }
                                            else
                                            {
                                                enkarli = ((tahta_degerleri[i, j] % 5) * 5 + 5) - (Math.Sqrt(Math.Pow((i - oyuncu[sayac].konum[0]), 2) + Math.Pow((j - oyuncu[sayac].konum[1]), 2)) / oyuncu_hamle_maliyeti[3]);
                                                oyuncu[3].hedef[0] = i;
                                                oyuncu[3].hedef[1] = j;
                                            }
                                        }
                                    }
                                }
                            }
                            enkarli = 0;
                            oyuncu[sayac].para -= oyuncu_hedef_maliyeti[3];
                        }

                        // Oyuncuyu adım adım hedefe götürme.
                        if (oyuncu[sayac].para <= 0)
                        {
                            oyuncu_kaybetme[sayac] = 1;
                        }
                        else
                        {
                            (altin_sorgu, tahta_degerleri) = await Hedefe_gitme(altin_sorgu, tahta_degerleri, sayac);
                        }
                        //oyuncu hedefe vardıysa hedefteki para kadar para ekle.
                        if (oyuncu[sayac].konum[0] == oyuncu[sayac].hedef[0] && oyuncu[sayac].konum[1] == oyuncu[sayac].hedef[1])
                        {
                            oyuncu[sayac].para += (tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] % 5) * 5 + 5;
                            tahta_degerleri[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 1;
                            altin_sorgu[oyuncu[sayac].konum[0], oyuncu[sayac].konum[1]] = 0;
                        }
                    }

                }

                for (i = 0; i < tahta_uzunlugu[0]; i++)
                {
                    for (j = 0; j < tahta_uzunlugu[1]; j++)
                    {
                        if(altin_sorgu[i,j] == 0)
                        {
                            bitis_tahta--;
                            
                        }
                        if(bitis_tahta == 0)
                        {
                            MessageBox.Show("OYUN BİTTİ!");
                            this.Close();
                        }
                    }
                }
                for (i = 0;i<4;i++)
                {
                    if(oyuncu[i].para == 0)
                    {
                        bitis_oyuncu_para--;
                    }
                    if (bitis_oyuncu_para == 0)
                    {
                        MessageBox.Show("OYUN BİTTİ!");
                        this.Close();
                    }
                }
                bitis_tahta = tahta_uzunlugu[0] * tahta_uzunlugu[1];
                bitis_oyuncu_para = 4;
            }
        }
    }
}
