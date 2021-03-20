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
        public static string CarsDetailsListed = "Tüm arabalar detaylı olarak listelendi";
        public static string CarsByBrandIdListed = "Tüm arabalar marka bazında listelendi";
        public static string CarsByColorIdListed = "Tüm arabalar renk bazında listelendi";
        public static string CarNameInvalid = "Araç adı en az iki karakter uzunluğunda olmalıdır";
        public static string CarDaiyPriceZero = "Araç günlük ücreti sıfırdan büyük olmalıdır";

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

        public static string MaintenanceTime = "Sistem bakımda olduğu için işleminiz gerçekleştirilemiyor";

    }
}
