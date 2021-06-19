using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entity katmanı include ediliyor
using EntityLibrary;

namespace BusinessLibrary
{
    public class TalepElle
    {
        // Entity katmanından fiyata bağlı talep oluşturacak işlemleri yapan context nesnesi
        private TalepVTisle context = new TalepVTisle();
        public bool TalepEkle(Talep talep) // talep ekleme metodu
        {
            bool result = false;
            if (context.TalepEkle(talep)) // talep ekleme işlemi başarılı ise
            {
                result = true;
            }
            return result;
        }

        // Bir urun onaylandığında o ürün ile ilgili alım emirlerini otomatik yerine getiren metot.
        public bool TalepKarsila(int piyasaID)
        {
            bool result = false;// entity katmandaki TalepKarsila metodu çağırılır.
            if (context.TalepKarsila(piyasaID)) // entity katmandaki talepkarsila sorunsuz çalışmışsa.
            {
                result = true;
            }
            return result;
        }


    }
}
