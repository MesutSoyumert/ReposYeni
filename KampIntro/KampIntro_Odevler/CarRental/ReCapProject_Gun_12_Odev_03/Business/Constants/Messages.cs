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
        public static string CarNotFound = "İstenen araba bulunamadı";
        public static string CarsDetailsListed = "Tüm arabalar detaylı olarak listelendi";
        public static string CarsByBrandIdListed = "Tüm arabalar marka bazında listelendi";
        public static string CarsByColorIdListed = "Tüm arabalar renk bazında listelendi";
        public static string CarNameInvalid = "Araç adı en az üç karakter uzunluğunda olmalıdır";
        public static string CarDaiyPriceZero = "Araç günlük ücreti sıfırdan büyük olmalıdır";
        public static string BrandNotFound = "Araç markası kayıtlı değil, tekrar girin";
        public static string ColorNotFound = "Araç rengi kayıtlı değil, tekrar girin";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncelllendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Tüm renkler listelendi";
        public static string ColorFound = "İstenen renk bulundu";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncelllendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Tüm markalar listelendi";
        public static string BrandFound = "İstenen marka bulundu";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncelllendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Tüm kullanıcılar listelendi";
        public static string UserFound = "İstenen kullanıcı bulundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncelllendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Tüm müşteriler listelendi";
        public static string CustomerFound = "İstenen müşteri bulundu";
        public static string CustomerNotFound = "İstenen müşteri bulunamadı";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated = "Kiralama güncelllendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalsListed = "Tüm kiralamalar listelendi";
        public static string RentalFound = "İstenen kiralama bulundu";
        public static string RentalNotFound = "İstenen kiralama bulunamadı";
        public static string RentalCarIsAlreadyRented = "İstenen araba zaten kiralanmış durumda, başka araba giriniz";

        public static string MaintenanceTime = "Sistem bakımda olduğu için işleminiz gerçekleştirilemiyor";
        public static string YesNoInputInvalid = "Evet veya Hayır cevaplarından birini giriniz";
    }
}
