# Yazılım Yapımı - Borsa Uygulaması (C# ve MS SQL Server ile)
o	Bu uygulama ile kullanıcılar sisteme kendileri kayıt olarak admin onayı ile para ve mal ekledikten sonra bütçeleri yettiği kadar mal – alım satımı yapabilirler.
•	Alt yapı ve teknoloji
o	Veri tabanı olarak MS SQL Server 15 kullanılmıştır.
o	Yazılım MS Visual Studio 2019 Community ile .NET core ve .NET Framwork destekleyen .NET 5 tabanlı olarak kodlanmıştır.
o	Çok katmanlı mimari ve nesne tabanlı programlama teknikleri kullanılmıştır.
•	Kurulum
o	Projeyi .zip olarak indirdikten sonra arşivi açın.
o	Veri tabanı BorsaApp\Borsa\BorsaAppDB içindeki borsaVT.mdf dosyasıdır. Bunu yerel MS SQL Server içine Attach etmeniz yeterlidir.
o	Veri tabanı bağlantı string değeri BorsaApp\Borsa\App.config içinde tanımlanmıştır. Eğer veri tabanı farklı bir sunucuda olacaksa 
<connectionStrings>
    <add connectionString="Data Source=.;Initial Catalog=borsaVT;Integrated Security=True" name="BorsaVTBaglantiStr"/>
  </connectionStrings>
Etiketi içinde “Data Source=BaşkaSunucu” yazabilirsiniz.
o	BorsaApp\Borsa\Borsa.sln başlangıç dosyasıdır.

•	Tasarım
o	Proje içindeki 
 
	Borsa projesi Presentation katmanıdır.
	BusinessLibrary ->> Enterprise Layer,
	DataLibrary ->> Data Layer,
	EntityLibrary ->> Entity Layer olarak tasarlanmıştır.

o	Veri tabanı birbirleriyle ilişkili ve gelişime açık, esnek bir şekilde tasarlanmıştır. Toplam sekiz tablo mevcuttur.
 
o	Veri tabanına kayıt ekleme, silme, güncelleme ve çok tablodan seçim işlemleri için stored procedure, fonksiyon, tetikleyici ve view nesneleri kodlanmıştır.
 
o	7 adet stored procedure,

 
o	6 adet function,

 
o	1 trigger,

 
ve 2 view kodlanmıştır.
o	Böylece bu veri tabanı programlama nesnelerine parametre gönderilerek CRUID işlemleri yaptırılarak bunların sunum, iş veya varlık katmanlarından bağımsız olması sağlanmıştır.

o	Kullanıcı Arayüz Tasarımı klavye kısayol tuşlarıyla ergonomik ve sade hale getirilmiştir. Kullanıcılar hiç fare kullanmadan yazılımı işletebilmektedirler.

 
•	Kullanım
 
o	Kullanıcı adı ve parolasıyla giriş yapılır. Kullanıcı mevcut ise veri tabanından yetki durumu okunarak admin için başka, standart kullanıcı için başka ana ekran gösterilir. Admin kullanıcı adları için “ma” veya “ae” ile başlayabilirsiniz. Parola ise demo sürümünde tüm kişiler için 123 olarak belirlenmiştir.
o	Aşağıda admin ana ekranı görünmektedir. Eğer kullanıcı yetkisi admin değilse “Yönetici İşlemleri” grubu görünmeyecektir.
o	Veri tabanındaki kişiler tablosunda bir kişinin yetki durumu 1 ise admin, 0 ise standart kullanıcıdır.
 

 
o	Hem yöneticiler, hem de kullanıcılar aynı ekran ile hesaplarına para ekleyebilirler.
 

o	Hesaba para eklendiğinde varsayılan onay durumu sıfırdır. Sıfır onaylanmadı, 1 ise onaylandı anlamına gelmektedir. Admin eklenen parayı onaylamak için kayıt seçip onay durumuna 1 girmelidir. Sistem hatalı girişleri kabul etmez.
 

 
o	Kişiler ellerindeki ürünleri pazara sunmak istediklerinde ürün türünü, miktarını, döviz cinsini ve birim fiyatını girerek admin onayına gönderirler.
 

o	Admin, satış izni istenen ürünü para onaylama ekranındaki gibi onaylar.
 

 
o	Ürün alım satımı gerçekleşebilmesi için alıcının yeterli onaylı bakiyesi ve stokta ürün olması gerekmektedir. Satış gerçekleştiğinde bu hareket veri tabanına kaydedilir, alıcının toplam bakiyesi azaltılır, satıcının toplam bakiyesi arttırılır, satıcının sattığı ürünün stoğu azaltılır. Bütün bunlar için veri tabanında bir tetikleyici yazılmıştır.
 

