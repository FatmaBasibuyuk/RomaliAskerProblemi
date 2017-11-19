using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Romali_Asker2
{
    public  interface IAsker
    {
        void AskerEkle(ulong askersayisi);
        string KalanAskerleriBul(ulong adimsayisi);
        Boolean BosMu();
        string CalismaZamani(ulong askersayisi, ulong adimsayisi);
    }
}
