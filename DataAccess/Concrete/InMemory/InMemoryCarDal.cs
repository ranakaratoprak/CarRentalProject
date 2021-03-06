using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 750, Description = "Audi A6", ModelYear = 2013},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 750, Description = "BMW 3.20I", ModelYear = 2020},
                new Car{CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 3500, Description = "BMW I8", ModelYear = 2016},
                new Car{CarId = 4, BrandId = 3, ColorId = 3, DailyPrice = 1785, Description = "Mercedes-Benz E200", ModelYear = 2020},
                new Car{CarId = 5, BrandId = 4, ColorId = 1, DailyPrice = 1785, Description = "Volvo S90", ModelYear = 2020},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p=>p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p=>p.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
