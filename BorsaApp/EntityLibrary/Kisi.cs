using System;

namespace EntityLibrary
{
    public class Kisi
    {
        public int KisiID { get; set; }
        public string Tcno { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAd { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public int Yetki { get; set; }
        public int Aktif { get; set; }

        public Kisi()
        {

        }
        // parametreli kişi nesnesi yapıcı metodu
        public Kisi(int kisiid, string ad, string soyad, string kullaniciad,
            string parola, string telefon, string eposta, string adres, int yetki, int aktif)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.KullaniciAd = kullaniciad;
            this.Parola = parola;
            this.Telefon = telefon;
            this.Adres = adres;
            this.Yetki = yetki;
            this.Aktif = aktif;
        }

    }
}
