To-Do Uygulaması (List Generic)
Bu proje, C# Windows Forms kullanılarak geliştirilmiş, basit bir masaüstü To-Do (Yapılacaklar) listesi uygulamasıdır. Proje, kullanıcıların yapılacak işleri kolayca kaydetmesini, görüntülemesini ve yönetmesini sağlar.

Kullanılan Teknolojiler
Geliştirme Dili: C#

Platform: .NET Framework

Arayüz: Windows Forms (WinForms)

Veri Yönetimi: Uygulama içinde tanımlanmış statik listeler (in-memory data)

Uygulama Özellikleri
Kullanıcı Kimlik Doğrulama: Sabit tanımlanmış kullanıcı adı ve şifre ile güvenli giriş ekranı.

Görev Ekleme: Kullanıcının, görev başlığı, kısa açıklama, detaylı açıklama, önem derecesi ve durumu gibi bilgileri girerek yeni görevler oluşturması.

Geniş Görev Listesi: Kaydedilen tüm görevlerin detaylı bir liste görünümünde sunulması.

Akıllı Filtreleme: Görevlerin durumlarına (Tamamlandı, İptal Edildi, Devam Ediyor) göre hızlıca filtrelenmesi.

Proje Dizini
Proje, okunabilirliği ve bakımı kolaylaştırmak amacıyla katmanlı bir mimariye sahiptir.

Entities: Uygulamanın temel veri modellerini (todo.cs, kullanici.cs) içerir.

BusinessService: Uygulamanın iş mantığını ve veri manipülasyonu işlemlerini yöneten servisleri (kullaniciServis.cs, todoServis.cs) barındırır.

Database: Veri depolama için kullanılan sanal veritabanı sınıfı (sanalDatabase.cs) bu klasörde yer alır.

Forms: Uygulamanın çeşitli arayüz pencerelerini (Form1.cs, sistemGiris.cs, yeniKayit.cs, kayitListe.cs) içerir.

Nasıl Kurulur ve Çalıştırılır?
Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

Projeyi bir Git istemcisi kullanarak klonlayın veya zip olarak indirin.

Visual Studio'yu açın ve çözüm dosyasını (ListGenericToDoUygulama.sln) yükleyin.

Çözümü derlemek için Visual Studio'da Build > Build Solution menüsünü kullanın.

Uygulamayı başlatmak için Debug > Start Without Debugging veya F5 tuşuna basın.

Önemli Not
Bu uygulama, verileri kalıcı olarak bir veritabanına kaydetmez. Uygulama her kapatılıp açıldığında, girilen tüm veriler sıfırlanır. Bu proje, C# ve Windows Forms'un temel veri yönetimi ve arayüz programlama yeteneklerini sergilemek amacıyla geliştirilmiştir.

Kullanıcı Bilgileri
Uygulamaya giriş yapmak için kullanılan sabit bilgiler aşağıdadır:

Kullanıcı Adı: test1

Şifre: 1