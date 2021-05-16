using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//entity katmanı include ediliyor
using EntityLibrary;

namespace BusinessLibrary
{
    public class BakiyeElle
    {
        // Entity katmanından kasadaki parayla ilgili işlemleri yapacak context nesnesi
        private BakiyeVTisle context = new BakiyeVTisle();
        public bool BakiyeEkle(Bakiye bakiye) // para ekleme metodu
        {
            bool result = false;
            if (context.BakiyeEkle(bakiye)) // para ekleme işlemi başarılı ise
            {
                result = true;
            }
            return result;
        }

        public bool BakiyeOnayla(Bakiye bakiye) // eklenen parayı onaylayan metot
        {
            bool result = false;
            // onaylama işlemi başarılı ise
            if (context.BakiyeOnayla(bakiye))
            {
                result = true;
            }
            return result;
        }
    }
}
