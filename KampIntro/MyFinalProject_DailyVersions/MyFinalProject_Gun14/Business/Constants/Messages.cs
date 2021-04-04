using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductModified = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductNameInvalid = "Ürün adı en az iki karakter uzunluğunda olmalıdır";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string MaintenanceTime = "Sistem bakımda olduğu için işleminiz gerçekleştirilemiyor";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = ("Bir kategoride en çok 10 ürün olabilir");
        public static string CategoryLimitExceeded = ("Kategori limiti aşıldığı için yeni ürün eklenemiyor");
        public static string AuthorizationDenied = "Bu işlemi yapmaya yetkiniz bulunmamaktadır";
        public static string AccessTokenCreated = "Erişim yetkisi oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string SuccessfulLogin = "Oturum açma başarılı";
        public static string PasswordError = "Parola hatalı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kullanıcı kaydı oluşturuldu";
        public static string UserOperationClaimsTaken = "Kullanıcı operasyon yetkileri oluşturuldu";
        public static string UserEmailTaken = "Kullanıcı e-postası alındı";
        public static string UserAdded = "Kullanıcı eklendi";

    }
}
