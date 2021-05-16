using System;
using EntityLibrary;

namespace BusinessLibrary
{
    public class KisiElle
    {
        // Entity katmanından kullanıcılar/kişiler ile ilgili işlemleri yapacak context nesnesi
        private KisiVTisle context = new KisiVTisle();
        public Kisi KisiAl(string kullaniciAd, string parola) // kullanıcı adı ve parola verileriyle kişi bilgilerini elde eden metot
        {
            return context.KisiAl(kullaniciAd,parola); // Entity katmanından KisiAl metodu çağırılıyor
        }
        public bool KisiEkle(Kisi kisi) // yeni kişi ekleyen metot
        {
            bool result = false;
            // Kullanıcı adı ve parola daha önceden kullanılmış mı diye bakılıyor.
            Kisi value = context.KisiAl(kisi.KullaniciAd, kisi.Parola);
            if (value == null) // kullanıcı adı daha önce kullanılmamış ise 
            {
                result = context.KisiEkle(kisi); // Entity katmanından KisiEkle metodu ile yeni kişi ekleniyor.
            }
            return result; // yeni kişi ekleme işleminin sonucu true / false olarak döndürülüyor.
        }
        public bool KisiGuncelle(Kisi kisi) // mevcut kişi bilgilerinde güncelleme yapan metot. KisiEkle ile aynı mantıkla çalışır.
        {
            bool result = false;
            Kisi value = context.KisiAl(kisi.KullaniciAd, kisi.Parola);
            if(value==null)
            {
                result = context.KisiGuncelle(kisi);
            }
            return result; 
        }
    }
}