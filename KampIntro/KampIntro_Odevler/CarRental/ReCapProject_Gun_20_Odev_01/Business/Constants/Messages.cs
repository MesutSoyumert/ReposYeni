using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncelllendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarsListed = "Tüm arabalar listelendi";
        public static string CarFound = "İstenen araba bulundu";
        public static string CarMostDetailsFound = "İstenen araba detayları ile birlikte bulundu";
        public static string CarNotFound = "İstenen araba bulunamadı";
        public static string CarsDetailsListed = "Tüm arabalar detaylı olarak listelendi";
        public static string CarsByBrandIdListed = "Tüm arabalar marka bazında listelendi";
        public static string CarsByColorIdListed = "Tüm arabalar renk bazında listelendi";
        public static string CarsMostDetailsListed = "Tüm arabalar tam detaylı olarak listelendi";
        public static string CarsMostDetailsByBrandListed = "Tüm arabalar marka bazında tam detaylı olarak listelendi";
        public static string CarsMostDetailsByColorListed = "Tüm arabalar renk bazında tam detaylı olarak listelendi";
        public static string CarsMostDetailsByColorAndByBrandListed = "İstenen renk ve marka bazında arabalar tam detaylı olarak listelendi";
        public static string CarsMostDetailsByColorAndByBrandNotFound = "İstenen renk ve marka bazında araba bulunamadı";

        public static string CarNameInvalid = "Araç adı en az üç karakter uzunluğunda olmalıdır";
        public static string CarDaiyPriceZero = "Araç günlük ücreti sıfırdan büyük olmalıdır";
        public static string BrandNotFound = "Araç markası kayıtlı değil, tekrar girin";
        public static string ColorNotFound = "Araç rengi kayıtlı değil, tekrar girin";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncelllendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Tüm renkler listelendi";
        public static string ColorFound = "İstenen renk bulundu";
        public static string ColorNameAlreadyExists = "Renk zaten var, başka renk ismi giriniz";
        public static string ColorToDeleteCarsHasColor = "Silinmek istenen renkte tanımlı araba mevcut, bu rengi silemesiniz, silmek için başka renk giriniz";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncelllendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Tüm markalar listelendi";
        public static string BrandFound = "İstenen marka bulundu";
        public static string BrandNameAlreadyExists = "Marka zaten var, başka marka ismi giriniz";
        public static string BrandToDeleteCarsHasBrand = "Silinmek istenen markada tanımlı araba mevcut, bu markayı silemesiniz, silmek için başka marka giriniz";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncelllendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Tüm kullanıcılar listelendi";
        public static string UserFound = "İstenen kullanıcı bulundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserCredentialsExists = "Girdiğiniz Kullanıcı Adı, Soyadı ve e-posta ile zaten kayıtlı bir kullanıcı var";
        public static string UserHasActiveCustomerExists = "Silinmek istenen kullanıcıya ait aktif müşteri kayıtları mevcuttur, kullanıcı silinmedi";
        public static string UserOperationClaimsTaken = "Kullanıcı operasyon yetkileri oluşturuldu";
        public static string UserEmailTaken = "Kullanıcı e-postası alındı";
        public static string AccessTokenCreated = "Erişim yetkisi oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string SuccessfulLogin = "Oturum açma başarılı";
        public static string PasswordError = "Parola hatalı";
        public static string UserRegistered = "Kullanıcı kaydı oluşturuldu";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncelllendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Tüm müşteriler listelendi";
        public static string CustomerFound = "İstenen müşteri bulundu";
        public static string CustomerNotFound = "İstenen müşteri bulunamadı";
        public static string CustomerCompanyNameAlreadyExists = "Girilen Şirket adı müşterilerde zaten var, başka Şirket adı ismi giriniz";
        public static string CustomerUserIdAlreadyExists = "Girilen kullanıcı koduna ait müşteri zaten kayıtlı, başka kullanıcı kodu giriniz";
        public static string CustomerHasActiveRentalExists = "Silinmek istenen müşterinin aktif kiralamaları mevcuttur, müşteriyi silemezsiniz";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated = "Kiralama güncelllendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Tüm kiralamalar listelendi";
        public static string RentalFound = "İstenen kiralama bulundu";
        public static string RentalNotFound = "İstenen kiralama bulunamadı";
        public static string RentalCarIsAlreadyRented = "İstenen araba zaten kiralanmış durumda, başka araba giriniz";
        public static string RentalsByCutomerIdListed = "İstenen müşterinin aktif kiralamaları listelendi";
        public static string RentalCarNotAvailable = "Kiralanmak istenen araba uygun durumda değil";

        public static string CardExist = "Kredi kartı sistemimizde zaten kayıtlı";


        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncelllendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImagesListed = "Tüm araba resimleri listelendi";
        public static string CarImageFound = "İstenen araba resmi bulundu";
        public static string CarImageNotFound = "İstenen araba resmi bulunamadı";
        public static string CarImagesByCarIdListed = "İstenen arabaya ait resimler listelendi";
        public static string CarImageUploadedSuccessfully = "Araba resmi başarıyla klasöre kopyalandı";
        public static string CarImageFileNotValid = "Yüklemek istediğiniz dosya türü .jpeg, .jpg veya .png olmalıdır, dosya yüklenmedi";
        public static string CarImageNumbersByCarExceeded(int imageLimit)
        {
            return $"Yüklemek istediğiniz araba resmi yüklenemedi, bir araba için eklenebilecek resim sayısı : {imageLimit}";
        }

        public static string MaintenanceTime = "Sistem bakımda olduğu için işleminiz gerçekleştirilemiyor";
        public static string YesNoInputInvalid = "Evet veya Hayır cevaplarından birini giriniz";
        public static string AuthorizationDenied = "Bu işlemi yapmaya yetkiniz bulunmamaktadır, Uygulama Yöneticinize başvurunuz";
    }
}
