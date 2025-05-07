# 🚀 CV Web Sitesi

Dinamik bir kişisel CV/Portfolyo web sitesi projesi. ASP.NET MVC mimarisi kullanılarak geliştirilmiş, admin panelli, tamamen dinamik bir kişisel tanıtım ve portfolyo platformu.

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

## 📋 Proje Özellikleri

### 🌐 Ziyaretçi Tarafı
- Profesyonel Ana Sayfa Tasarımı
- Hakkımda Bölümü
- Dinamik Yetenek ve Beceri Gösterimi
- Eğitim ve Deneyim Zaman Çizelgesi
- Portfolyo / Proje Galerisi
- İletişim Formu
- Sosyal Medya Entegrasyonu
- Blog / Makale Sayfası
- Responsive (Mobil Uyumlu) Tasarım

## 🛠️ Kullanılan Teknolojiler

- **Backend Framework**: ASP.NET MVC 5
- **Programlama Dili**: C#
- **ORM**: Entity Framework (Code First yaklaşımı)
- **Veritabanı**: SQL Server
- **Frontend**: HTML5, CSS3, JavaScript, jQuery
- **Stil Kütüphanesi**: Bootstrap 4
- **Animasyonlar**: Animate.css, Wow.js
- **İkonlar**: Font Awesome
- **Grafikler**: Chart.js
- **Geliştirme Ortamı**: Visual Studio 2022

## 📦 Veritabanı Yapısı

Proje, Code First yaklaşımıyla aşağıdaki temel entity'lere sahiptir:

- **About**: Kişisel bilgiler
- **Skills**: Yetenekler ve beceriler
- **Experiences**: İş deneyimleri
- **Education**: Eğitim bilgileri
- **Projects**: Portfolyo projeleri
- **Blogs**: Blog yazıları
- **Contact**: İletişim formu mesajları
- **Admin**: Yönetici hesap bilgileri
- **SocialMedia**: Sosyal medya linkleri

## 🚀 Kurulum

1. Projeyi klonlayın:
   ```
   git clone https://github.com/yusufbalcidev/Cv-web-sitesi.git
   ```

2. Visual Studio'da projeyi açın.

3. `Web.config` dosyasında veritabanı bağlantı dizesini kendi ortamınıza göre düzenleyin:
   ```xml
   <connectionStrings>
     <add name="CVDbContext" connectionString="Data Source=YOURSERVER;Initial Catalog=CVDatabase;Integrated Security=True;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. Package Manager Console'da migrations komutlarını çalıştırın:
   ```
   Enable-Migrations
   Add-Migration InitialCreate
   Update-Database
   ```

5. Projeyi çalıştırın ve tarayıcıda görüntüleyin.

6. `/Admin` URL'sine giderek admin paneline erişin (varsayılan giriş bilgileri: kullanıcı adı: `admin`, şifre: `123456`).

## 💡 Özelleştirme

Siteyi kendi CV'nize ve kişisel bilgilerinize göre özelleştirmek için:

1. Admin paneline giriş yapın
2. "Hakkımda" bölümünden kişisel bilgilerinizi güncelleyin
3. "Yetenekler" bölümünden kendi becerilerinizi ekleyin
4. "Deneyim" ve "Eğitim" bilgilerinizi ekleyin
5. "Portfolyo" bölümünden projelerinizi yükleyin
6. "Blog" bölümünden makalelerinizi yazın


## 🔄 Proje Mimarisi

Proje, standart MVC (Model-View-Controller) mimarisi kullanılarak yapılandırılmıştır:

- **Models**: Veritabanı tablolarını temsil eden sınıflar ve view model'lar
- **Views**: Razor sözdizimi ile oluşturulmuş görünümler
- **Controllers**: İş mantığını yöneten denetleyiciler
- **Data**: Veritabanı context'i ve migrations
- **Content**: CSS, JavaScript ve diğer statik kaynaklar

## 🔮 Geliştirilecek Özellikler

- Çoklu dil desteği
- Karanlık/Aydınlık tema seçeneği
- PDF CV indirme özelliği
- Gelişmiş SEO optimizasyonu
- Sertifika galerisi
- Testimonial/Referans bölümü

## 👨‍💻 Geliştirici

Bu proje [Yusuf Balci](https://github.com/yusufbalcidev) tarafından geliştirilmiştir.



⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın! ⭐
