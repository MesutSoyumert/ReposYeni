using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba Kiralama Projesi Geliştirici Test İşlemleri Menüsü");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. Renk İşlemleri");
            Console.WriteLine("2. Marka İşlemleri");
            Console.WriteLine("3. Araba İşlemleri");
            Console.WriteLine("4. Kullanıcı İşlemleri");
            Console.WriteLine("5. Müşteri İşlemleri");
            Console.WriteLine("6. Kiralama İşlemleri");
            Console.WriteLine("9. Çıkış");
            Console.WriteLine("Seçiminiz : ");

            switch (Console.ReadLine())
            {
                case "1":
                    //ColorTest();
                    break;
                case "2":
                    //BrandTest();
                    break;
                case "3":
                    //CarTest();
                    break;
                case "4":
                    //UserTest();
                    break;
                case "5":
                    //CustomerTest();
                    break;
                case "6":
                    //RentalTest();
                    break;
                case "9":
                    break;
            };
        }
        //private static void ColorTest()
        //{
        //colorAgain:
        //    Console.WriteLine("Renk Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Renk Ekleme");
        //    Console.WriteLine("2. Renk Güncelleme");
        //    Console.WriteLine("3. Renk Silme");
        //    Console.WriteLine("4. Renk Görüntüleme");
        //    Console.WriteLine("5. Renkleri Görüntüleme");
        //    Console.WriteLine("Renk İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            ColorInsert();
        //            break;
        //        case "2":
        //            ColorModify();
        //            break;
        //        case "3":
        //            ColorRemove();
        //            break;
        //        case "4":
        //            ColorList();
        //            break;
        //        case "5":
        //            ColorsList();
        //            break;
        //    };
        //    goto colorAgain;
        //}
        //private static void ColorInsert()
        //{
        //    Console.WriteLine("Renk Adını Giriniz : ");

        //    var colorName = Console.ReadLine();

        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var colorInsertResult = colorManager.Add(new Color { Name = colorName });

        //    if (colorInsertResult.Success == true)
        //    {
        //        Console.WriteLine(colorInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(colorInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void ColorModify()
        //{
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    var colorCode = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Renk Adını Giriniz : ");

        //    var colorName = Console.ReadLine();

        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var colorModifyResult = colorManager.Update(new Color { Id = colorCode, Name = colorName });

        //    if (colorModifyResult.Success == true)
        //    {
        //        Console.WriteLine(colorModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(colorModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void ColorRemove()
        //{
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    var colorCode = Convert.ToInt32(Console.ReadLine());

        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var colorModifyRemove = colorManager.Delete(new Color { Id = colorCode });

        //    if (colorModifyRemove.Success == true)
        //    {
        //        Console.WriteLine(colorModifyRemove.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(colorModifyRemove.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void ColorList()
        //{
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    var colorCode = Convert.ToInt32(Console.ReadLine());

        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var result = colorManager.GetById(colorCode);

        //    if (result.Success == true)
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.Name);
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void ColorsList()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var resultGetAll = colorManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var color in resultGetAll.Data)
        //        {
        //            Console.WriteLine(color.Id + "/" + color.Name);
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
        //private static void BrandTest()
        //{
        //brandAgain:
        //    Console.WriteLine("Marka Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Marka Ekleme");
        //    Console.WriteLine("2. Marka Güncelleme");
        //    Console.WriteLine("3. Marka Silme");
        //    Console.WriteLine("4. Marka Görüntüleme");
        //    Console.WriteLine("5. Markaları Görüntüleme");
        //    Console.WriteLine("Marka İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            BrandInsert();
        //            break;
        //        case "2":
        //            BrandModify();
        //            break;
        //        case "3":
        //            BrandRemove();
        //            break;
        //        case "4":
        //            BrandList();
        //            break;
        //        case "5":
        //            BrandsList();
        //            break;
        //    };
        //    goto brandAgain;
        //}
        //private static void BrandInsert()
        //{
        //    Console.WriteLine("Marka Adını Giriniz : ");

        //    var brandName = Console.ReadLine();

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var brandInsertResult = brandManager.Add(new Brand { Name = brandName });

        //    if (brandInsertResult.Success == true)
        //    {
        //        Console.WriteLine(brandInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(brandInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void BrandModify()
        //{
        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    var brandCode = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Marka Adını Giriniz : ");

        //    var brandName = Console.ReadLine();

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var brandModifyResult = brandManager.Update(new Brand { Id = brandCode, Name = brandName });

        //    if (brandModifyResult.Success == true)
        //    {
        //        Console.WriteLine(brandModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(brandModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void BrandRemove()
        //{
        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    var brandCode = Convert.ToInt32(Console.ReadLine());

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var brandRemoveResult = brandManager.Delete(new Brand { Id = brandCode });

        //    if (brandRemoveResult.Success == true)
        //    {
        //        Console.WriteLine(brandRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(brandRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void BrandList()
        //{
        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    var brandCode = Convert.ToInt32(Console.ReadLine());

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var result = brandManager.GetById(brandCode);

        //    if (result.Success == true)
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.Name);
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void BrandsList()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var resultGetAll = brandManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var brand in resultGetAll.Data)
        //        {
        //            Console.WriteLine(brand.Id + "/" + brand.Name);
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
        //private static void CarTest()
        //{
        //carAgain:
        //    Console.WriteLine("Araba Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Araba Ekleme");
        //    Console.WriteLine("2. Araba Güncelleme");
        //    Console.WriteLine("3. Araba Silme");
        //    Console.WriteLine("4. Araba Görüntüleme");
        //    Console.WriteLine("5. Arabaları Görüntüleme");
        //    Console.WriteLine("6. Arabaları Renk Bazında Görüntüleme");
        //    Console.WriteLine("7. Arabaları Marka Bazında Görüntüleme");
        //    Console.WriteLine("8. Arabaları Detaylı Görüntüleme");
        //    Console.WriteLine("Araba İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            CarInsert();
        //            break;
        //        case "2":
        //            CarModify();
        //            break;
        //        case "3":
        //            CarRemove();
        //            break;
        //        case "4":
        //            CarList();
        //            break;
        //        case "5":
        //            CarsList();
        //            break;
        //        case "6":
        //            CarsListByColor();
        //            break;
        //        case "7":
        //            CarsListByBrand();
        //            break;
        //        case "8":
        //            CarDetailsList();
        //            break;
        //    };
        //    goto carAgain;
        //}
        //public static void CarInsert()
        //{
        //    carBrandCodeAgain:

        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    int carBrandCode = Convert.ToInt32(Console.ReadLine());

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var resultBrand = brandManager.GetById(carBrandCode);
            
        //    if (resultBrand.Success == false || resultBrand.Data == null)
        //    {
        //        Console.WriteLine(Messages.BrandNotFound);
        //        goto carBrandCodeAgain;
        //    }

        //    Console.WriteLine("Araba Markası :");
        //    Console.WriteLine(resultBrand.Data.Name);
        //    Console.ReadLine();


        //    carColorCodeAgain:
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    int carColorCode = Convert.ToInt32(Console.ReadLine());
            
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var resultColor = colorManager.GetById(carColorCode);
            
        //    if (resultColor.Success == false || resultColor.Data == null)
        //    {
        //        Console.WriteLine(Messages.ColorNotFound);
        //        goto carColorCodeAgain;
        //    }

        //    Console.WriteLine("Araba Rengi :");
        //    Console.WriteLine(resultColor.Data.Name);
        //    Console.ReadLine();

        //    Console.WriteLine("Model Yılını Giriniz : ");

        //    var carModelYear = Console.ReadLine();

        //    Console.WriteLine("Günlük Ücreti Giriniz : ");

        //    var carDailyPrice = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Tanımı Giriniz : ");

        //    var carDescription = Console.ReadLine();

        //    var carIsRented = false;

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var carInsertResult = carManager.Add(new Car
        //    {
        //        BrandId = carBrandCode,
        //        ColorId = carColorCode,
        //        ModelYear = carModelYear,
        //        DailyPrice = carDailyPrice,
        //        Description = carDescription,
        //        IsRented = carIsRented
        //    });

        //    if (carInsertResult.Success == true)
        //    {
        //        Console.WriteLine(carInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(carInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CarModify()
        //{
        //    Console.WriteLine("Araba Kodunu Giriniz : ");

        //    var carCode = Convert.ToInt32(Console.ReadLine());

        //carBrandCodeAgain:

        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    int carBrandCode = Convert.ToInt32(Console.ReadLine());

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    var resultBrand = brandManager.GetById(carBrandCode);

        //    if (resultBrand.Success == false || resultBrand.Data == null)
        //    {
        //        Console.WriteLine(Messages.BrandNotFound);
        //        goto carBrandCodeAgain;
        //    }

        //    Console.WriteLine("Araba Markası :");
        //    Console.WriteLine(resultBrand.Data.Name);
        //    Console.ReadLine();


        //carColorCodeAgain:
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    int carColorCode = Convert.ToInt32(Console.ReadLine());

        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    var resultColor = colorManager.GetById(carColorCode);

        //    if (resultColor.Success == false || resultColor.Data == null)
        //    {
        //        Console.WriteLine(Messages.ColorNotFound);
        //        goto carColorCodeAgain;
        //    }

        //    Console.WriteLine("Araba Rengi :");
        //    Console.WriteLine(resultColor.Data.Name);
        //    Console.ReadLine();

        //    Console.WriteLine("Model Yılını Giriniz : ");

        //    var carModelYear = Console.ReadLine();

        //    Console.WriteLine("Günlük Ücreti Giriniz : ");

        //    var carDailyPrice = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Tanımı Giriniz : ");

        //    var carIsRentedInput = Console.ReadLine();

        //    carIsRentedInputAgain:

        //    Console.WriteLine("Araba Kirada mı? (Evet/Hayır) : ");

        //    bool carIsRented = true;

        //    if (carIsRentedInput == "Evet")
        //    {
        //        carIsRented = true;
        //    }
        //    else if (carIsRentedInput == "Hayır")
        //    {
        //        carIsRented = false;
        //    }
        //    else Console.WriteLine(Messages.YesNoInputInvalid);
        //         Console.ReadLine();
        //         goto carIsRentedInputAgain;

        //    var carDescription = Console.ReadLine();

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var carModifyResult = carManager.Update(new Car
        //    {
        //        Id = carCode,
        //        BrandId = carBrandCode,
        //        ColorId = carColorCode,
        //        ModelYear = carModelYear,
        //        DailyPrice = carDailyPrice,
        //        Description = carDescription,
        //        IsRented = carIsRented
        //    });

        //    if (carModifyResult.Success == true)
        //    {
        //        Console.WriteLine(carModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(carModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CarRemove()
        //{
        //    Console.WriteLine("Araba Kodunu Giriniz : ");

        //    var carCode = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var carRemoveResult = carManager.Delete(new Car { Id = carCode });

        //    if (carRemoveResult.Success == true)
        //    {
        //        Console.WriteLine(carRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(carRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //}

        //private static void CarList()
        //{
        //    Console.WriteLine("Araba Kodunu Giriniz : ");

        //    var carCode = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var result = carManager.GetById(carCode);

        //    if (result.Success == true && result.Data != null)
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.ColorId);
        //        Console.WriteLine(result.Data.BrandId);
        //        Console.WriteLine(result.Data.DailyPrice);
        //        Console.WriteLine(result.Data.Description);
        //        Console.WriteLine(result.Data.ModelYear);
        //        Console.WriteLine(result.Data.IsRented);
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CarNotFound);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CarsList()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultGetAll = carManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var car in resultGetAll.Data)
        //        {
        //            Console.WriteLine(car.Id + "/" +
        //                    car.ColorId + "/" +
        //                    car.BrandId + "/" +
        //                    car.DailyPrice + "/" +
        //                    car.Description + "/" +
        //                    car.ModelYear + "/" +
        //                    car.IsRented
        //                    );
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
        //private static void CarsListByColor()
        //{
        //    Console.WriteLine("Renk Kodunu Giriniz : ");

        //    var colorCode = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultGetCarsByColorId = carManager.GetCarsByColorId(colorCode);

        //    if (resultGetCarsByColorId.Success == true)
        //    {
        //        foreach (var car in resultGetCarsByColorId.Data)
        //        {
        //            Console.WriteLine(car.Id + "/" +
        //                car.ColorId + "/" +
        //                car.BrandId + "/" +
        //                car.DailyPrice + "/" +
        //                car.Description + "/" +
        //                car.ModelYear + "/" +
        //                car.IsRented);
        //        }
        //    }
        //    Console.WriteLine(resultGetCarsByColorId.Message);
        //    Console.ReadLine();
        //}
        //private static void CarsListByBrand()
        //{
        //    Console.WriteLine("Marka Kodunu Giriniz : ");

        //    var brandCode = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultGetCarsByBrandId = carManager.GetCarsByBrandId(brandCode);

        //    if (resultGetCarsByBrandId.Success == true)
        //    {
        //        foreach (var car in resultGetCarsByBrandId.Data)
        //        {
        //            Console.WriteLine(car.Id + "/" +
        //                    car.ColorId + "/" +
        //                    car.BrandId + "/" +
        //                    car.DailyPrice + "/" +
        //                    car.Description + "/" +
        //                    car.ModelYear + "/" +
        //                    car.IsRented);
        //        }
        //    }
        //    Console.WriteLine(resultGetCarsByBrandId.Message);
        //    Console.ReadLine();
        //}
        //private static void CarDetailsList()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultGetCarDetails = carManager.GetCarDetails();

        //    if (resultGetCarDetails.Success == true)
        //    {
        //        foreach (var car in resultGetCarDetails.Data)
        //        {
        //            Console.WriteLine(car.CarName + "/" +
        //                              car.BrandName + "/" +
        //                              car.ColorName + "/" +
        //                              car.DailyPrice + "/" +
        //                              car.IsRented);
        //        }
        //    }
        //    Console.WriteLine(resultGetCarDetails.Message);
        //    Console.ReadLine();
        //}
        //private static void UserTest()
        //{
        //userAgain:
        //    Console.WriteLine("Kullanıcı Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Kullanıcı Ekleme");
        //    Console.WriteLine("2. Kullanıcı Güncelleme");
        //    Console.WriteLine("3. Kullanıcı Silme");
        //    Console.WriteLine("4. Kullanıcı Görüntüleme");
        //    Console.WriteLine("5. Kullanıcıları Görüntüleme");
        //    Console.WriteLine("Kullanıcı İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            UserInsert();
        //            break;
        //        case "2":
        //            UserModify();
        //            break;
        //        case "3":
        //            UserRemove();
        //            break;
        //        case "4":
        //            UserList();
        //            break;
        //        case "5":
        //            UsersList();
        //            break;
        //    };
        //    goto userAgain;
        //}
        //private static void UserInsert()
        //{
        //    Console.WriteLine("Kullanıcı Adını Giriniz : ");

        //    var userFirstName = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı Soyadını Giriniz : ");

        //    var userLastName = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı E-postasını Giriniz : ");

        //    var userEmail = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı Parolasını Giriniz : ");

        //    var userPassword = Console.ReadLine();


        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var userInsertResult = userManager.Add(new User
        //    {
        //        FirstName = userFirstName,
        //        LastName = userLastName,
        //        Email = userEmail,
        //        Password = userPassword
        //    });

        //    if (userInsertResult.Success == true)
        //    {
        //        Console.WriteLine(userInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(userInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void UserModify()
        //{

        //    Console.WriteLine("Kullanıcı Kodunu Giriniz : ");

        //    var userCode = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kullanıcı Adını Giriniz : ");

        //    var userFirstName = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı Soyadını Giriniz : ");

        //    var userLastName = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı E-postasını Giriniz : ");

        //    var userEmail = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı Parolasını Giriniz : ");

        //    var userPassword = Console.ReadLine();


        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var userModifyResult = userManager.Update(new User
        //    {
        //        Id = userCode,
        //        FirstName = userFirstName,
        //        LastName = userLastName,
        //        Email = userEmail,
        //        Password = userPassword
        //    });

        //    if (userModifyResult.Success == true)
        //    {
        //        Console.WriteLine(userModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(userModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void UserRemove()
        //{
        //    Console.WriteLine("Kullanıcı Kodunu Giriniz : ");

        //    var userCode = Convert.ToInt32(Console.ReadLine());

        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var userRemoveResult = userManager.Delete(new User { Id = userCode });

        //    if (userRemoveResult.Success == true)
        //    {
        //        Console.WriteLine(userRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(userRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void UserList()
        //{
        //    Console.WriteLine("Kullanıcı Kodunu Giriniz : ");

        //    var userCode = Convert.ToInt32(Console.ReadLine());

        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var result = userManager.GetById(userCode);

        //    if (result.Success == true && result.Data != null)
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.FirstName);
        //        Console.WriteLine(result.Data.LastName);
        //        Console.WriteLine(result.Data.Email);
        //        Console.WriteLine(result.Data.Password);
        //        Console.WriteLine(result.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.UserNotFound);
        //        Console.ReadLine();
        //    }
        //}
        //private static void UsersList()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var resultGetAll = userManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var user in resultGetAll.Data)
        //        {
        //            Console.WriteLine(user.Id + "/" + user.FirstName + "/" + user.LastName + "/" + user.Email + "/" + user.Password);
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
        //private static void CustomerTest()
        //{
        //customerAgain:
        //    Console.WriteLine("Müşteri Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Müşteri Ekleme");
        //    Console.WriteLine("2. Müşteri Güncelleme");
        //    Console.WriteLine("3. Müşteri Silme");
        //    Console.WriteLine("4. Müşteri Görüntüleme");
        //    Console.WriteLine("5. Müşterileri Görüntüleme");
        //    Console.WriteLine("Müşteri İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            CustomerInsert();
        //            break;
        //        case "2":
        //            CustomerModify();
        //            break;
        //        case "3":
        //            CustomerRemove();
        //            break;
        //        case "4":
        //            CustomerList();
        //            break;
        //        case "5":
        //            CustomersList();
        //            break;
        //    };
        //    goto customerAgain;
        //}
        //private static void CustomerInsert()
        //{
        //customerUserCodeAgain:
        //    Console.WriteLine("Müşteri Kullanıcı Kodunu Giriniz : ");

        //    int customerUserId = Convert.ToInt32(Console.ReadLine());

        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var resultUser = userManager.GetById(customerUserId);

        //    if (resultUser.Success == false || resultUser.Data == null)
        //    {
        //        Console.WriteLine(Messages.UserNotFound);
        //        goto customerUserCodeAgain;
        //    }

        //    Console.WriteLine("Kullanıcı Adı, Soyadı :");
        //    Console.WriteLine(resultUser.Data.FirstName + " " + resultUser.Data.LastName);
        //    Console.ReadLine();

        //    Console.WriteLine("Müşteri Şirket Adını Giriniz : ");

        //    var customerCompanyName = Console.ReadLine();

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var customerInsertResult = customerManager.Add(new Customer
        //    {
        //        UserId = customerUserId,
        //        CompanyName = customerCompanyName
        //    });

        //    if (customerInsertResult.Success == true)
        //    {
        //        Console.WriteLine(customerInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(customerInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CustomerModify()
        //{

        //    Console.WriteLine("Müşteri Kodunu Giriniz : ");

        //    var customerCode = Convert.ToInt32(Console.ReadLine());

        //customerUserCodeAgain:
        //    Console.WriteLine("Müşteri Kullanıcı Kodunu Giriniz : ");

        //    int customerUserId = Convert.ToInt32(Console.ReadLine());

        //    UserManager userManager = new UserManager(new EfUserDal());

        //    var resultUser = userManager.GetById(customerUserId);

        //    if (resultUser.Success == false || resultUser.Data == null)
        //    {
        //        Console.WriteLine(Messages.UserNotFound);
        //        goto customerUserCodeAgain;
        //    }

        //    Console.WriteLine("Müşteri Şirket Adını Giriniz : ");

        //    var customerCompanyName = Console.ReadLine();

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var customerModifyResult = customerManager.Update(new Customer
        //    {
        //        Id = customerCode,
        //        UserId = customerUserId,
        //        CompanyName = customerCompanyName
        //    });

        //    if (customerModifyResult.Success == true)
        //    {
        //        Console.WriteLine(customerModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(customerModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CustomerRemove()
        //{
        //    Console.WriteLine("Müşteri Kodunu Giriniz : ");

        //    var customerCode = Convert.ToInt32(Console.ReadLine());

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var customerRemoveResult = customerManager.Delete(new Customer { Id = customerCode });

        //    if (customerRemoveResult.Success == true)
        //    {
        //        Console.WriteLine(customerRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(customerRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CustomerList()
        //{
        //    Console.WriteLine("Müşteri Kodunu Giriniz : ");

        //    var customerCode = Convert.ToInt32(Console.ReadLine());

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var result = customerManager.GetById(customerCode);

        //    if (result.Success == true && result.Data != null)
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.UserId);
        //        Console.WriteLine(result.Data.CompanyName);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CustomerNotFound);
        //        Console.ReadLine();
        //    }
        //}
        //private static void CustomersList()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var resultGetAll = customerManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var customer in resultGetAll.Data)
        //        {
        //            Console.WriteLine(customer.Id + "/" + customer.UserId + "/" + customer.CompanyName);
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
        //private static void RentalTest()
        //{
        //rentalAgain:
        //    Console.WriteLine("Kiralama Test İşlemleri");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine("1. Kiralama Ekleme");
        //    Console.WriteLine("2. Kiralama Güncelleme");
        //    Console.WriteLine("3. Kiralama Silme");
        //    Console.WriteLine("4. Kiralama Görüntüleme");
        //    Console.WriteLine("5. Kiralamaları Görüntüleme");
        //    Console.WriteLine("Kiralama İşlemini Seçiniz : ");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            RentalInsert();
        //            break;
        //        case "2":
        //            RentalModify();
        //            break;
        //        case "3":
        //            RentalRemove();
        //            break;
        //        case "4":
        //            RentalList();
        //            break;
        //        case "5":
        //            RentalsList();
        //            break;
        //    };
        //    goto rentalAgain;
        //}
        //private static void RentalInsert()
        //{
        //    rentalCarIdAgain:
        //    Console.WriteLine("Kiralanacak Araba Kodunu Giriniz : ");

        //    var rentalCarId = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultCarGetById = carManager.GetById(rentalCarId);

        //    if (resultCarGetById.Success == true && resultCarGetById.Data != null)
        //    {
        //        Console.WriteLine(resultCarGetById.Data.Id);
        //        Console.WriteLine(resultCarGetById.Data.ColorId);
        //        Console.WriteLine(resultCarGetById.Data.BrandId);
        //        Console.WriteLine(resultCarGetById.Data.DailyPrice);
        //        Console.WriteLine(resultCarGetById.Data.Description);
        //        Console.WriteLine(resultCarGetById.Data.ModelYear);
        //        Console.WriteLine(resultCarGetById.Data.IsRented);
        //        Console.WriteLine(resultCarGetById.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CarNotFound);
        //        Console.ReadLine();
        //        goto rentalCarIdAgain;
        //    }
        //    if (resultCarGetById.Data.IsRented == true)
        //    {
        //        Console.WriteLine(Messages.RentalCarIsAlreadyRented);
        //        Console.ReadLine();
        //        goto rentalCarIdAgain;
        //    }

        //rentalCustomerIdAgain:

        //    Console.WriteLine("Kiralayacak Müşteri Kodunu Giriniz : ");

        //    var rentalCustomerId = Convert.ToInt32(Console.ReadLine());
            
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var resultCustomerGetById = customerManager.GetById(rentalCustomerId);

        //    if (resultCustomerGetById.Success == true && resultCustomerGetById.Data != null)
        //    {
        //        Console.WriteLine(resultCustomerGetById.Data.Id);
        //        Console.WriteLine(resultCustomerGetById.Data.UserId);
        //        Console.WriteLine(resultCustomerGetById.Data.CompanyName);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CustomerNotFound);
        //        Console.ReadLine();
        //        goto rentalCustomerIdAgain;
        //    }

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Gününü Giriniz (GG) : ");

        //    var rentalRentDateDay = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Ayını Giriniz (AA) : ");

        //    var rentalRentDateMonth = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Yılını Giriniz (YYYY) : ");

        //    var rentalRentDateYear = Convert.ToInt32(Console.ReadLine());

        //    var rentalRentDate = new DateTime(rentalRentDateYear, rentalRentDateMonth, rentalRentDateDay, 0, 0, 0);


        //    DateTime rentalReturnDate = new DateTime() {  };

        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());


        //    var rentalInsertResult = rentalManager.Add(new Rental
        //    {
        //        CarId = rentalCarId,
        //        CustomerId = rentalCustomerId,
        //        RentDate = rentalRentDate,
        //        ReturnDate = rentalReturnDate
        //    });

        //    if (rentalInsertResult.Success == true)
        //    {
        //        Console.WriteLine(rentalInsertResult.Message);
        //        Console.ReadLine();

        //        CarManager carModifyManager = new CarManager(new EfCarDal());
        //        Console.WriteLine("Car Rented Update");
        //        Console.WriteLine(resultCarGetById.Data.Id);

        //        var carModifyResult = carModifyManager.Update(new Car
        //        {
        //            Id = resultCarGetById.Data.Id,
        //            BrandId = resultCarGetById.Data.BrandId,
        //            ColorId = resultCarGetById.Data.ColorId,
        //            ModelYear = resultCarGetById.Data.ModelYear,
        //            DailyPrice = resultCarGetById.Data.DailyPrice,
        //            Description = resultCarGetById.Data.Description,
        //            IsRented = true
        //        });
        //        //transaction mamangement eklendiği zaman carModify result handle edilecek
        //    }
        //    else
        //    {
        //        Console.WriteLine(rentalInsertResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void RentalModify()
        //{
        //    Console.WriteLine("Kiralama Kodunu Giriniz : ");

        //    var rentalCode = Convert.ToInt32(Console.ReadLine());

        //rentalCarIdAgain:
        //    Console.WriteLine("Kiralanacak Araba Kodunu Giriniz : ");

        //    var rentalCarId = Convert.ToInt32(Console.ReadLine());

        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var resultCarGetById = carManager.GetById(rentalCarId);

        //    if (resultCarGetById.Success == true && resultCarGetById.Data != null)
        //    {
        //        Console.WriteLine(resultCarGetById.Data.Id);
        //        Console.WriteLine(resultCarGetById.Data.ColorId);
        //        Console.WriteLine(resultCarGetById.Data.BrandId);
        //        Console.WriteLine(resultCarGetById.Data.DailyPrice);
        //        Console.WriteLine(resultCarGetById.Data.Description);
        //        Console.WriteLine(resultCarGetById.Data.ModelYear);
        //        Console.WriteLine(resultCarGetById.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CarNotFound);
        //        Console.ReadLine();
        //        goto rentalCarIdAgain;
        //    }

        //rentalCustomerIdAgain:

        //    Console.WriteLine("Kiralayacak Müşteri Kodunu Giriniz : ");

        //    var rentalCustomerId = Convert.ToInt32(Console.ReadLine());

        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        //    var resultCustomerGetById = customerManager.GetById(rentalCustomerId);

        //    if (resultCustomerGetById.Success == true && resultCustomerGetById.Data != null)
        //    {
        //        Console.WriteLine(resultCustomerGetById.Data.Id);
        //        Console.WriteLine(resultCustomerGetById.Data.UserId);
        //        Console.WriteLine(resultCustomerGetById.Data.CompanyName);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.CustomerNotFound);
        //        Console.ReadLine();
        //        goto rentalCustomerIdAgain;
        //    }

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Gününü Giriniz (GG) : ");

        //    var rentalRentDateDay = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Ayını Giriniz (AA) : ");

        //    var rentalRentDateMonth = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Başlangıç Tarihinin Yılını Giriniz (YYYY) : ");

        //    var rentalRentDateYear = Convert.ToInt32(Console.ReadLine());

        //    var rentalRentDate = new DateTime(rentalRentDateYear, rentalRentDateMonth, rentalRentDateDay, 0, 0, 0);

        //    Console.WriteLine("Kiralama Bitiş Tarihinin Gününü Giriniz (GG) : ");

        //    var rentalReturnDateDay = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Bitiş Tarihinin Ayını Giriniz (AA) : ");

        //    var rentalReturnDateMonth = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kiralama Bitiş Tarihinin Yılını Giriniz (YYYY) : ");

        //    var rentalReturnDateYear = Convert.ToInt32(Console.ReadLine());

        //    var rentalReturnDate = new DateTime(rentalReturnDateYear, rentalReturnDateMonth, rentalReturnDateDay, 0, 0, 0);

        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());

        //    var rentalModifyResult = rentalManager.Update(new Rental
        //    {
        //        Id = rentalCode,
        //        CarId = rentalCarId,
        //        CustomerId = rentalCustomerId,
        //        RentDate = rentalRentDate,
        //        ReturnDate = rentalReturnDate,
        //    });

        //    if (rentalModifyResult.Success == true)
        //    {
        //        Console.WriteLine(rentalModifyResult.Message);
        //        Console.ReadLine();
        //        CarManager carModifyManager = new CarManager(new EfCarDal());

        //        var carModifyResult = carModifyManager.Update(new Car
        //        {
        //            Id = resultCarGetById.Data.Id,
        //            BrandId = resultCarGetById.Data.BrandId,
        //            ColorId = resultCarGetById.Data.ColorId,
        //            ModelYear = resultCarGetById.Data.ModelYear,
        //            DailyPrice = resultCarGetById.Data.DailyPrice,
        //            Description = resultCarGetById.Data.Description,
        //            IsRented = false
        //        });
        //        //transaction mamangement eklendiği zaman carModify result handle edilecek
        //    }
        //    else
        //    {
        //        Console.WriteLine(rentalModifyResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void RentalRemove()
        //{
        //    Console.WriteLine("Kiralama Kodunu Giriniz : ");

        //    var rentalCode = Convert.ToInt32(Console.ReadLine());

        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());

        //    var rentalRemoveResult = rentalManager.Delete(new Rental { Id = rentalCode });

        //    if (rentalRemoveResult.Success == true)
        //    {
        //        Console.WriteLine(rentalRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(rentalRemoveResult.Message);
        //        Console.ReadLine();
        //    }
        //}
        //private static void RentalList()
        //{
        //    Console.WriteLine("Kiralama Kodunu Giriniz : ");

        //    var rentalCode = Convert.ToInt32(Console.ReadLine());

        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());

        //    var result = rentalManager.GetById(rentalCode);

        //    if (result.Success == true && result.Data != null  )
        //    {
        //        Console.WriteLine(result.Data.Id);
        //        Console.WriteLine(result.Data.CarId);
        //        Console.WriteLine(result.Data.CustomerId);
        //        Console.WriteLine(result.Data.RentDate);
        //        Console.WriteLine(result.Data.ReturnDate);
        //        Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine(Messages.RentalNotFound);
        //        Console.ReadLine();
        //    }
        //}
        //private static void RentalsList()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());

        //    var resultGetAll = rentalManager.GetAll();

        //    if (resultGetAll.Success == true)
        //    {
        //        foreach (var rental in resultGetAll.Data)
        //        {
        //            Console.WriteLine(rental.Id + "/" + rental.CarId + "/" + rental.CustomerId + "/" + rental.RentDate + "/" + rental.ReturnDate);
        //        }
        //    }
        //    Console.WriteLine(resultGetAll.Message);
        //    Console.ReadLine();
        //}
    }
}