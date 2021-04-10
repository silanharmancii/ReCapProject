# Car Rental Project - Backend

Entity Framework kullanılmıştır. Proje geliştirme süresince AOP, FluentValidation, Autofac, WenAPI kullanılıp, SOLID prensiplerine bağlı kalınmıştır. 

## Proje İçeriği:

- Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.
- Bir araba nesnesi oluşturunuz. "Car"
- Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
- InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
- Car nesnesine ek olarak;
- Brand ve Color nesneleri ekleyiniz(Entity)
- Brand-->Id,Name
- Color-->Id,Name
- Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)
- Sisteme Generic IEntityRepository altyapısı yazınız.
- Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.
- GetCarsByBrandId , GetCarsByColorId servislerini yazınız.
- Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.
- Araba ismi minimum 2 karakter olmalıdır
- Araba günlük fiyatı 0'dan büyük olmalıdır.
- CarRental Projenizde Core katmanı oluşturunuz.
- IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
- Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
- Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
- Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
- Core katmanında Results yapılandırması yapınız.
- Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
- Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName
- Kullanıcılar ve müşteriler ilişkilidir.
- Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), --ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır
- Projenizde bu entity'leri oluşturunuz.
- CRUD operasyonlarını yazınız.
- Yeni müşteriler ekleyiniz.
- Arabayı kiralama imkanını kodlayınız. Rental-->Add
- Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.
- WebAPI katmanını kurunuz.
- Business katmanındaki tüm servislerin Api karşılığını yazınız.
- Car Rental Projenize Autofac desteği ekleyiniz.
- Car Rental Projenize FluentValidation desteği ekleyiniz.
- Car Rental Projenize AOP desteği ekleyiniz.
- ValidationAspect ekleyiniz.
- CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
- Api üzerinden arabaya resim ekleyecek sistemi yazınız.
- Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
- Resim silme, güncelleme yetenekleri ekleyiniz.
- Bir arabanın en fazla 5 resmi olabilir.
- Resmin eklendiği tarih sistem tarafından atanacaktır.
- Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
- Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)
- RentACar projenize JWT entegrasyonu yapınız.
- Cache, Transaction ve Performance aspectlerini ekleyiniz.





