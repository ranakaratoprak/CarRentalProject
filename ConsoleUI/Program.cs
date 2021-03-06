using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //CRUD: Create Read Update Delete
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(1).BrandName); 
             

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach(var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId);
            }

        }
    }
}
