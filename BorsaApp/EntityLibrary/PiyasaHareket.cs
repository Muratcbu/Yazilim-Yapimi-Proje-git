using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class PiyasaHareket
    {
        public int HareketID { get; set; }
        public int PiyasaID { get; set; }
        public int AliciID { get; set; }
        public int SaticiID { get; set; }
        public float Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public PiyasaHareket()
        {

        }
        public PiyasaHareket(int hareketID, int piyasaID, int aliciID, int saticiID, float miktar, DateTime tarih)
        {

        }
    }
    
}
