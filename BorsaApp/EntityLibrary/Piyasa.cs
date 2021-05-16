using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Piyasa
    {
        public int PiyasaID { get; set; }
        public int KisiID { get; set; }
        public int UrunID { get; set; }
        public decimal Fiyat { get; set; }
        public int DovizID { get; set; }
        public double Miktar { get; set; }
        public int Onaydurumu { get; set; }
        public DateTime Tarih { get; set; }
        public Piyasa()
        {

        }
        // parametreli Piyasa nesnesi yapıcı metodu. 
        public Piyasa(int piyasaid, int kisiid, int urunid, decimal fiyat, int dovizID, float miktar, int onaydurumu, DateTime tarih)
        {
            this.PiyasaID = piyasaid;
            this.KisiID = kisiid;
            this.UrunID = urunid;
            this.Fiyat = fiyat;
            this.DovizID = dovizID;
            this.Miktar = miktar;
            this.Onaydurumu = onaydurumu;
            this.Tarih = tarih;
        }
    }
    

}
