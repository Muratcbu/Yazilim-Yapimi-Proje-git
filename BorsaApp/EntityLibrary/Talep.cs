using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Talep
    {
        public int TalepID { get; set; }
        public int KisiID { get; set; }
        public int UrunID { get; set; }
        public double Fiyat { get; set; }
        public float Miktar { get; set; }
        public DateTime Tarih { get; set; }
        
        public int TalepDurum { get; set; }
        public Talep()
        {

        }
        //parametreli Bakiye nesnesi yapısı metodu.
        public Talep(int talepID, int kisiID, int urunID, double fiyat, float miktar, DateTime tarih, int talepdurum)
        {
            this.TalepID = talepID;
            this.KisiID = kisiID;
            this.UrunID = urunID;
            this.Fiyat = fiyat;
            this.Miktar = miktar;
            this.Tarih = tarih;
            this.TalepDurum = talepdurum;
        }
    }
}
