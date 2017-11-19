using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
namespace Romali_Asker2
{
    public class RomaliAsker : IAsker
    {
    
        public ulong AdimSayisi { get; set; }
        public int DiziUzunlugu { get; set; }
        private object[] Queue;
        private int indis = -1;
        private int rear = 0;
        private ulong AskerSayisi = 0;
        private ulong KalanAskerSayisi = 0;
        public RomaliAsker(ulong AskerSayisi)
        {
            this.AskerSayisi = AskerSayisi;
            Queue = new object[AskerSayisi];
        }
        public void AskerEkle(ulong askersayisi)
        {
                 if (indis == -1)
                    indis = 0;          
                 if (Convert.ToUInt64(rear) == AskerSayisi )
                 {
                     rear = 0;
                     Queue[rear] = askersayisi;
                 }
                 else
                     Queue[rear++] = askersayisi;   
        }
        public bool BosMu()
        {
            return (AskerSayisi == 0);
        }
      
        public string KalanAskerleriBul(ulong adimsayisi)
        {
            int j = 0;
            string mesaj = "";
            DiziUzunlugu = Queue.Length;
            this.AdimSayisi = adimsayisi;
            do
            {
                if (BosMu())
                    throw new Exception("Queue boş.");          
                for (ulong i = 0; i < AdimSayisi; i++)
                {
                    indis = j;
                    j++;
                    if (indis == DiziUzunlugu - 1)
                        j = 0;   
                   if (Queue[indis] == null)
                    {
                        i--;
                        continue;
                    }
                }
                Queue[indis] = null;
                AskerSayisi--;
                KalanAskerSayisi = AskerSayisi;
            } while (KalanAskerSayisi != 2);

            mesaj = "Kalan Askerler:";
            for (int i = 0; i < DiziUzunlugu; i++)
            {
                if (Queue[i] == null)
                    continue;
                else
                {
                    int gecici = Convert.ToInt32(Queue[i])+1;
                    
                    mesaj += "\n" + gecici.ToString() + ". asker sağ kaldı.";

                   
                }
            }
            mesaj += "\n";
            mesaj += "Ölen Asker Sayisi:" + (Convert.ToUInt64(DiziUzunlugu) - KalanAskerSayisi);
            return mesaj;
        }

        public  string CalismaZamani(ulong askersayisi, ulong adimsayisi)
        {
            string temp = "";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (ulong i = 0; i < askersayisi; i++)
            {
                AskerEkle(i);
            }
            MessageBox.Show(KalanAskerleriBul(adimsayisi));
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            temp = t.TotalMilliseconds.ToString();
            return "Çalışma Zamanı:" + temp;
        }
    }
}
