#	YAZILIM YAPIMI - BORSA UYGULAMASI (C# VE MS SQL SERVER)
[README.pdf](https://github.com/Muratcbu/Yazilim-Yapimi-Proje-git/files/6490342/README.pdf)

-	Bu uygulama ile kullanıcılar sisteme kendileri kayıt olarak admin onayı ile para ve mal ekledikten sonra bütçeleri yettiği kadar mal – alım satımı yapabilirler.
##	Alt yapı ve teknoloji
-	Veri tabanı olarak MS SQL Server 15 kullanılmıştır.
-	Yazılım MS Visual Studio 2019 Community ile .NET core ve .NET Framwork destekleyen .NET 5 tabanlı olarak kodlanmıştır.
-	Çok katmanlı mimari ve nesne tabanlı programlama teknikleri kullanılmıştır.
##	Kurulum
-	Projeyi .zip olarak indirdikten sonra arşivi açın.
-	Veri tabanı BorsaApp\Borsa\BorsaAppDB içindeki borsaVT.mdf dosyasıdır. Bunu yerel MS SQL Server içine Attach etmeniz yeterlidir.
-	Veri tabanı bağlantı string değeri BorsaApp\Borsa\App.config içinde tanımlanmıştır. Eğer veri tabanı farklı bir sunucuda olacaksa 
\<connectionStrings\>
    \<add connectionString="Data Source=.;Initial Catalog=borsaVT;Integrated Security=True" name="BorsaVTBaglantiStr"/\>
  \</connectionStrings\>  
  Etiketi içinde “Data Source=BaşkaSunucu” yazabilirsiniz.  
BorsaApp\Borsa\Borsa.sln başlangıç dosyasıdır.

## Tasarım  
- Proje içindeki 
![image](https://user-images.githubusercontent.com/77682988/118417539-2aea3b80-b6bd-11eb-87b0-d91a0ca5040b.png)

 
   * **Borsa** projesi Presentation katmanıdır.
   * **BusinessLibrary** ->> Enterprise Layer,
   * **DataLibrary** ->> Data Layer,
   * **EntityLibrary** ->> Entity Layer olarak tasarlanmıştır.

- Veri tabanı birbirleriyle ilişkili ve gelişime açık, esnek bir şekilde tasarlanmıştır. Toplam sekiz tablo mevcuttur.  
![image](https://user-images.githubusercontent.com/77682988/118417575-53723580-b6bd-11eb-838b-501ba65a1ad5.png)

 
- Veri tabanına kayıt ekleme, silme, güncelleme ve çok tablodan seçim işlemleri için stored procedure, fonksiyon, tetikleyici ve view nesneleri kodlanmıştır.
 
	7 adet stored procedure,  
![image](https://user-images.githubusercontent.com/77682988/118417603-77ce1200-b6bd-11eb-8937-0155c8444c58.png)

	6 adet function,  
![image](https://user-images.githubusercontent.com/77682988/118417651-c67bac00-b6bd-11eb-95ec-5436e892f37f.png)
 
	1 trigger,  
![image](https://user-images.githubusercontent.com/77682988/118417655-cd0a2380-b6bd-11eb-9e37-c533c4c51e36.png)    
    
    ve 2 view kodlanmıştır.  
    ![image](https://user-images.githubusercontent.com/77682988/118417671-dd220300-b6bd-11eb-8662-9e94d1a94066.png)

-	Böylece bu veri tabanı programlama nesnelerine parametre gönderilerek CRUID işlemleri yaptırılarak bunların sunum, iş veya varlık katmanlarından bağımsız olması sağlanmıştır.

-	Kullanıcı Arayüz Tasarımı klavye kısayol tuşlarıyla ergonomik ve sade hale getirilmiştir. Kullanıcılar hiç fare kullanmadan yazılımı işletebilmektedirler.

 
##	Kullanım
![image](https://user-images.githubusercontent.com/77682988/118417752-312ce780-b6be-11eb-9256-bbaa6a0e1c5a.png)
-	Kullanıcı adı ve parolasıyla giriş yapılır. Kullanıcı mevcut ise veri tabanından yetki durumu okunarak admin için başka, standart kullanıcı için başka ana ekran gösterilir. Admin kullanıcı adları için “ma” veya “ae” ile başlayabilirsiniz. Parola ise demo sürümünde tüm kişiler için 123 olarak belirlenmiştir.  

-	Aşağıda admin ana ekranı görünmektedir. Eğer kullanıcı yetkisi admin değilse “Yönetici İşlemleri” grubu görünmeyecektir.  
-	Veri tabanındaki kişiler tablosunda bir kişinin yetki durumu 1 ise admin, 0 ise standart kullanıcıdır.  
![image](https://user-images.githubusercontent.com/77682988/118417812-76511980-b6be-11eb-99f4-89151a87eb82.png)

-   Hem yöneticiler, hem de kullanıcılar aynı ekran ile hesaplarına para ekleyebilirler.
![image](https://user-images.githubusercontent.com/77682988/118417836-9aacf600-b6be-11eb-968d-986175aa8cde.png)

-	Hesaba para eklendiğinde varsayılan onay durumu sıfırdır. Sıfır onaylanmadı, 1 ise onaylandı anlamına gelmektedir. Admin eklenen parayı onaylamak için kayıt seçip onay durumuna 1 girmelidir. Sistem hatalı girişleri kabul etmez.  
![image](https://user-images.githubusercontent.com/77682988/118417853-a5678b00-b6be-11eb-9202-f28e212a2a37.png)

-	Kişiler ellerindeki ürünleri pazara sunmak istediklerinde ürün türünü, miktarını, döviz cinsini ve birim fiyatını girerek admin onayına gönderirler.  
![image](https://user-images.githubusercontent.com/77682988/118417860-aef0f300-b6be-11eb-834d-2e89881f36af.png)

-	Admin, satış izni istenen ürünü para onaylama ekranındaki gibi onaylar.
![image](https://user-images.githubusercontent.com/77682988/118417863-b6b09780-b6be-11eb-9ad2-73c84d00b04f.png)

-	Ürün alım satımı gerçekleşebilmesi için alıcının yeterli onaylı bakiyesi ve stokta ürün olması gerekmektedir. Satış gerçekleştiğinde bu hareket veri tabanına kaydedilir, alıcının toplam bakiyesi azaltılır, satıcının toplam bakiyesi arttırılır, satıcının sattığı ürünün stoğu azaltılır. Bütün bunlar için veri tabanında bir tetikleyici yazılmıştır.
![image](https://user-images.githubusercontent.com/77682988/118417879-c6c87700-b6be-11eb-97a8-27c403495ac8.png)

-	Alıcı, alım imkanı doğrultusunda ürüne bir fiyat belirlemektedir. Ürün ve fiyat bilgisi alıcı tarafından sisteme girilmektedir. Veri tabanında ürüne ait satıcı fiyatları alış fiyatı ile karşılaştırılmaktadır. Alıcının istediği fiyattan satış yoksa, belirlenen fiyattan satış yapılana kadar alıcının alış işlemi bekletilmektedir. Satıcılar, alıcının belirlediği fiyat üzerinden satış yaptığında alış/satış işlemi gerçekleştirilecektir. ![image](https://user-images.githubusercontent.com/36658972/122827140-a9ee1780-d2ec-11eb-9710-0008e89c74a3.png)

-	Kullanıcı borsa üzerinden alış/satış yaptığı ürünlere ait raporlama yapabilmektedir. Kullanıcı tarafından tarih aralığı girilmesi istenir. Belirtilen tarih aralığında  alış/satış işlemine ait rapor dokümanı istenilen formatta kullanıcıya rapor edilir. 

-	Alıcı sisteme TL dışında farklı para tipi ekleyebilmektedir. Üç farklı titpi sistem tarafından kabul edilmektedir. Alıcının eklediği para tipi admin onayına gönderilir. Admin onayladığında para tipi sisteme eklenir, veri tabanına kaydedilir. Adminin para tipini onayladığı tarihteki TCMB Döviz Kuruna göre TL cinsinden miktarı hesaplanıp tutar TL olarak sisteme eklenmektedir.![image](https://user-images.githubusercontent.com/36658972/122827052-92af2a00-d2ec-11eb-85ce-8ab08520608f.png)

-	Sisteme Muhasebe_kullanıcısı eklenmektedir. Muhasebe kullanıcısı aracılık hizmeti olarak ücret almaktadır. Aracılık ücreti yüzde 1 olarak belirlenmiştir. Alım işlemi yapan kullanıcıda yüzde 1 tutarında muhasebe ücreti tahsil edilmektedir. 
