To-Do Uygulaması (List Generic)
Bu proje, C# Windows Forms kullanılarak geliştirilmiş basit bir To-Do (Yapılacaklar) listesi uygulamasıdır. Uygulama, yapılacak işleri kaydetmenizi, listelemenizi ve durumlarına göre filtrelemenizi sağlar.

Kullanılan Teknolojiler
Dil: C#

Platform: .NET Framework

Arayüz: Windows Forms (WinForms)

Veri Depolama: Uygulama içinde tanımlanan statik listeler (in-memory data)

Uygulama Özellikleri
Kullanıcı Girişi: Uygulama, sabit tanımlanmış kullanıcı adı ve şifre ile giriş yapma ekranına sahiptir.

Görev Yönetimi: Yeni görevler (To-Do) ekleme, başlık, açıklama, önem derecesi ve durum gibi bilgileri kaydetme.

Görev Listeleme: Kaydedilen tüm görevleri listeleme imkanı.

Durum Filtreleme: Görevleri "Tamamlandı", "İptal Edildi" ve diğer durumlarına göre filtreleme.

Sanal Veritabanı: Veriler, kalıcı bir veritabanı yerine uygulamanın kendisinde tanımlanan statik listelerde (List<T>) saklanır.

Kullanıcı Bilgileri
Uygulamaya giriş yapmak için aşağıdaki sabit kullanıcı bilgileri kullanılabilir:

Kullanıcı Adı: test1

Şifre: 1

Proje Yapısı
Entities: Veri modelleri (todo.cs, kullanici.cs) bu klasörde yer alır.

BusinessService: İş mantığı servisleri (kullaniciServis.cs, todoServis.cs) bu klasörde bulunur.

Database: Sanal veritabanı (sanalDatabase.cs) bu klasörde tanımlanmıştır.

Kurulum ve Çalıştırma
Bu projeyi Visual Studio'da açın.

Çözümü derleyin (Build Solution).

Uygulamayı çalıştırın (Start).

Giriş ekranında yukarıdaki kullanıcı bilgilerini kullanarak sisteme giriş yapın.

Not: Bu uygulama, verileri kalıcı olarak saklamaz. Uygulama her yeniden başlatıldığında, kaydedilen tüm görevler silinir.