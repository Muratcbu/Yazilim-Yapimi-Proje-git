using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kntity katmanı include ediliyor.
using EntityLibrary;

namespace BusinessLibrary
{
    public class PiyasaHareketElle
    {
        // Entity katmanından context nesnesi ile alım-satım işlemleri gerçekleştiriliyor.
        private PiyasaHareketVTisle context = new PiyasaHareketVTisle();
        
        // satış işlemini gerçekleştiren metot.
        public bool PiyasaHareketEkle(PiyasaHareket piyasahareket)
        {
            bool result = false;
            //entity katmanındaki PiyasaHareketEkle metodu yani satış kaydı eklediyse
            if (context.PiyasaHareketEkle(piyasahareket))
            {
                result = true;
            }
            return result; // yeni satış kaydedilemediyse.
        }
    }
}
