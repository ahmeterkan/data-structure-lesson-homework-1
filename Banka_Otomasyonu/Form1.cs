using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PriorityQueue Siralikuyruk = new PriorityQueue(20);
        CircularArrayTypedQueue Sirasizkuyruk = new CircularArrayTypedQueue(20);
        int[] dizi =new int[20];
        private void btnSirasizListele_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 1; i < 21; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i;
                
                m.IslemSuresi = r.Next(60, 600);
                Sirasizkuyruk.Insert(m);
            }
            
            int toplamGecenSure = 0;
            int ortlamaBeklemeSüresi = 0;
            string temp = "";
            for (int i = 0; i < 20; i++)
            {
                Musteri m = new Musteri();
                m = Sirasizkuyruk.Remove();
                toplamGecenSure += m.IslemSuresi;
                dizi[i] = toplamGecenSure;
                ortlamaBeklemeSüresi = toplamGecenSure / (i+1);
                temp += "Müşteri No:" + m.MusteriNo + Environment.NewLine + "İşlem Süresi:" + m.IslemSuresi + Environment.NewLine + 
                    "Toplam Bekleme Süresi:"+ toplamGecenSure + Environment.NewLine + "Ortalama Geçen Süre:" + ortlamaBeklemeSüresi + Environment.NewLine + Environment.NewLine;
                Siralikuyruk.Insert(m);
            }

            txtListele.Text = temp;
            txtToplamSure.Text = toplamGecenSure.ToString() ;
            txtOrtalamaSure.Text = ortlamaBeklemeSüresi.ToString();
        }

        private void btnSiraliListe_Click(object sender, EventArgs e)
        {
            
            int toplamGecenSure = 0;
            int ortlamaBeklemeSüresi = 0;
            string temp = "";
            int fark = 0;
            float toplamakazanilansure = 0;
            for (int i = 1; i < 21; i++)
            {
                Musteri m = new Musteri();
                m = Siralikuyruk.Remove();
                toplamGecenSure += m.IslemSuresi;
                //Yüzde bulma
                toplamakazanilansure = 100-(toplamGecenSure * 100 / dizi[m.MusteriNo-1]);
                //Fark bulma
                fark = dizi[m.MusteriNo - 1] - toplamGecenSure;
                ortlamaBeklemeSüresi =(toplamGecenSure / i);

                temp += "Müşteri No:" + m.MusteriNo + Environment.NewLine + "İşlem Süresi:" + m.IslemSuresi + Environment.NewLine +
                    "Toplam Bekleme Süresi"+ toplamGecenSure + Environment.NewLine + "Ortalama Geçen Süre" + ortlamaBeklemeSüresi +
                    Environment.NewLine+"Sıralı Liste ile Sırasız Liste Arasındaki Fark:"+fark+ Environment.NewLine + 
                    "Süre Kazancı('%'de olarak): "+toplamakazanilansure+Environment.NewLine + Environment.NewLine;
               //Eger sadece ekrana kazanç sağlanan müşteriler yazdırılacaksa yukardaki temp yerine aşagıdaki if yazılacaktır 
               /* if (fark > 0)
                {
                    temp += "Müşteri No:" + m.MusteriNo + Environment.NewLine + "İşlem Süresi:" + m.IslemSuresi + Environment.NewLine +
                    "Toplam Bekleme Süresi" + toplamGecenSure + Environment.NewLine + "Ortalama Geçen Süre" + ortlamaBeklemeSüresi +
                    Environment.NewLine + "Sıralı Liste ile Sırasız Liste Arasındaki Fark:" + fark + Environment.NewLine +
                    "Süre Kazancı('%'de olarak): " + toplamakazanilansure + Environment.NewLine + Environment.NewLine;
                }*/
            }
            txtSiraliListele.Text = temp;
            txtSiraliToplamSure.Text = toplamGecenSure.ToString();
            txtSiraliOrtalamaSure.Text = ortlamaBeklemeSüresi.ToString();
        }
    }
}
