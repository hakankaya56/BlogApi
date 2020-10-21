Projede katmanlı mimari yapısı kullanıldı, 5 tane katman bulunmaktadır.Katmanlar  Core, Entites, DataAccess, Business ve WebApi,
Core katmanı Repository bulundurduğum katman, EntityFramework ORM aracını kullandığım için EfEntityRepositoryBase olarak isimlendirdim.
Entites katmanı  veritabanında tablolarıma karşılık classları oluşturduğum tablo bu katmanda ayrıca complex type classları oluşturabiliriz. 
DataAccess katmanı veritabanı contextin  bulunduğu katman, ayrıca  Repository generic yapı bir yapıda olduğu için, aynı proje içinde birden fazla context ile  çalışmama yardımcı oluyor. 
Business katmanı servislerimi barındığım ayrıca  validatons kontrollerin yapıldığı katman,

Kullandığım kütüphaneler
Auto Mapper
İki nesneye birbirine eşleyip kod karmaşası yaratmamak için kullandığım bir araçtır. 

Fluent Validation 
Validationları daha sistemik ve düzenli uygulayabilmek  için kullandım.

Microsoft.AspNetCore.Mvc.NewtonsoftJson
Json datasını seralize edebilmek için kullandım.

Daha geniş bir zamanım olsaydı eğer projede muhakkak bir login işlemi yapıp token geri döndürürdüm. Serviste yapılacak tüm requestleri token ile yapılmasını sağlardım. 
Rest servisi kontrülünü daha iyi sağlamak açısından swagger kurardım. 
Serviste  id leri  Data Protection kullanarak gönderirdim. 
Kesinlikle Loglama yapardım. 
