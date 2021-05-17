using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int OlcuBirimiID { get; set; }
        public string Aciklama { get; set; }
        public int OnayDurumu { get; set; }
        public Urun()
        {

        }
        // Urun nesnesi parametreli yapıcı metodu
        public Urun(int urunid, string urunad, int olcubirimiid, string aciklama, int onaydurumu)
        {
            this.UrunID = urunid;
            this.UrunAd = urunad;
            this.OlcuBirimiID = olcubirimiid;
            this.Aciklama = aciklama;
            this.OnayDurumu = onaydurumu;
        }
    }
    
}
