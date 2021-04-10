# ReCapProject 

RecapProject, araç kiralama projesidir. Angular ve Bootstrap v4.0 kullanılarak hazırlanmıştır.</br>
**Component**:HTML, Typescript ve CSS dosyalarını içerir. Typescript dosyaları genel olarak ilgili componentin servisini kullanılır.</br>
**Services**: Backend tarafında oluşturulan API ile bağlantının sağlantığı kısımdır. Proje için gerekli olan metodlar burada yazıldıktan sonra Component kısmında kullanılır.</br>
**Models**: API'den gelen veriler, Frontend içerisinde özellik olarak burada tutulur.</br>
**Pipes**: Veriyi farklı görünümler eklemek için kullanılır.Örneğin harflerin büyük ya da küçük yazılması, fiyata para değerinin eklenmesi gibi...</br>
**Guards**: Kullanıcının belli sayfalara ulaşması için yapması gereken işlemlere yönlendirilmesini sağlar. Örneğin kullanıcının aracı kiralayabilmesi için giriş yapmış olması gerekir, giriş yapmamışsa işlem yapacağı esnada giriş sayfasına yönlendirilir, gibi...</br>
**Interceptors**: Client tarafından sunucuya giden requestlerin modifiye edilerek sunucuya ulaşmasını sağlar.</br>

## Proje içeriği: 

- Bootstrap entegrasyonu yapıldı.
- Marka, Renk, Müşterilerin listelesi,
- Arabaların listesi(BrandId yerine BrandName, ColorId yerine ColorName gösterilmektedir.)
- Kiralamaların listesi(CarId yerine BrandName, CustomerId yerine FirstName + LastName şeklinde gösterilmektedir.) oluşturuldu.
- Brand listesinde herhangi bir marka seçildiğinde, o markaya ait arabaların listelenmesi,
- Color listesinde herhangi bir renk seçildiğinde, o renge ait arabaların listelenmesi sağlandı.
- Car listesinde bir arabaya tıklandığında o arabaya ait detay sayfası oluşturuldu. Bu sayfada bu araca ait resimleri de gösterilmektedir.
- Car, Brand, Color için pipe ile arama desteği eklendi.
- Car sayfasına 2 adet açılır kutu ekleyindi. Html-Select Option. Bu açılır kutularda sırasıyla Marka ve Renk listelendi.
- Açılır kutuların yanına "Filtrele" butonu eklendi.
- Filtrele butonuna tıklandığında apiden ilgili filtreye uygun arabalar listelendi.
- Araba detay sayfasında "Kirala" butonu ekleyiniz. Bu aracı kiralayabilecek sistemi yazıldı. Araba hali hazırda başkası tarafından seçilen tarih aralığında kiralanmışsa, kiralama işlemi yapılmamaktadır.
- Kiralama işleminde tarihler seçildikten sonra, yeni bir sayfada kredi kartıyla ödeme desteği getirildi.
- Ödeme işlemi için api'de sahte bir banka servisi yazıldı.
- Tüm işlemler için Toastr desteği eklendi.
- Reactive Forms kullanarak Brand, Color, Car Ekleme sayfalarını oluşturuldu.
- Brand,Color,Car listesinde güncelleme butonu eklendi. Tıklanan ilgili elemanın detay sayfasına yönlendirerek güncelleme imkanı verilmektedir.
- Login/Register yetenekleri getirildi.
- Kiralama esnasında müşterinin findeks puanını sorgulayacak sahte servis eklendi.
- LocalStorage için servis yazıldı. Ekleme/Getirme/Silme
- Giriş ve register için nav'a butonlar eklendi.Eğer giriş yapılmamışsa nav'da bu butonlar olsun. Giriş yapılmışsa bu butonlar yerine müşteri adı ex: "İsim Soyisim" yazmaktadır.
- Kullanıcı adını yazdığınız kısım açılır kutu şeklindedir. Kullanıcı, bilgilerini görüp güncelleyebilir.
- Kredi kartıyla ödeme alındığında kullanıcıya kredi kartını kaydedelim mi? Sorusu yöneltilir. Kaydetmek isteyen müşteriye sonraki ödemede kayıtlı kredi kartı gösterilir.



