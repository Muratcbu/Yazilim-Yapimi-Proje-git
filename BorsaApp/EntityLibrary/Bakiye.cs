using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLibrary
{
    // Kasaya para eklemekte kullanılan sınıf
    public class Bakiye
    {
        public int BakiyeID { get; set; }
        public int KisiID { get; set; }
        public decimal Bakiyepara { get; set; }
        public int Dovizcinsi { get; set; }
        public int OnayDurumu { get; set; }
        public DateTime Tarih { get; set; }
        public Bakiye()
        {

        }
        //parametreli Bakiye nesnesi yapısı metodu.
        public Bakiye(int bakiyeID, int kisiID, decimal bakiyepara, int dovizcinsi, int onaydurumu, DateTime tarih)
        {
            this.BakiyeID = bakiyeID;
            this.KisiID = kisiID;
            this.Bakiyepara = bakiyepara;
            this.Dovizcinsi = dovizcinsi;
            this.OnayDurumu = onaydurumu;
            this.Tarih = tarih;
        }
    }
}
