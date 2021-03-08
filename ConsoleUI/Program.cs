using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        //CRUD: Create Read Update Delete
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("------------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(1).BrandName);

            Console.WriteLine("------------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId);
            }

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User {UserId=2, FirstName = "Yılmazeren", LastName = "Karatoprak", Email = "yılmazeren@hotmail.com", Password = "23651"});
            
            //carManager.Add(new Car { CarId=3,CarName="MERCEDES", BrandId=3, ColorId=3, DailyPrice=1500, ModelYear=2020, Description= "Mercedes E Kiralık Otomobil" });
            //brandManager.Add(new Brand {BrandId=3, BrandName="Mercedes" });
            //colorManager.Add(new Color {ColorId=3, ColorName="Siyah"});
        }
    }
}
