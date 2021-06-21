using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entity katmanı include ediliyor.
using EntityLibrary;

namespace BusinessLibrary
{
    public class PiyasaElle
    {
        private PiyasaVTisle context = new PiyasaVTisle();// stok ile ilgili işlemleri yapacak Entity katmanı nesnesi.
        // stoğa yeni ürün eklyen metot   
        public bool PiyasaEkle(Piyasa piyasa)
           {
               bool result = false;
            // entity sınıfından PiyasaEkle metodu ile veri tabanına yeni ürün ekleme başarılı ise.
            if (context.PiyasaEkle(piyasa))
               {
                   result = true;
               }
               return result; // yeni ürün ekleme başarısız olduysa.
        }

           
        // eklenen ürünü onaylama metodu. Piyasa ekle metodu ile aynı mantıkla çalışır.
        public bool PiyasaOnayla(Piyasa piyasa) 
           {
               bool result = false;
               if (context.PiyasaOnayla(piyasa))
               {
                   result = true;
               }
               return result;
           }
    }
}
