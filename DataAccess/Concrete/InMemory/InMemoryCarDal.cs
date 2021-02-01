using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; // _ global 
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=12,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Eski model arabamız"},
                new Car{Id=2,BrandId=12,ColorId=2,ModelYear=2005,DailyPrice=1500,Description="İkinci arabamız"},
                new Car{Id=3,BrandId=12,ColorId=3,ModelYear=2010,DailyPrice=3000,Description="Üçüncü arabamız"},
                new Car{Id=4,BrandId=12,ColorId=2,ModelYear=2021,DailyPrice=5000,Description="Son model arabamız"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public Car GetById(int carId)
        {
            Car carToGetById = _cars.SingleOrDefault(c => c.Id == carId);
            return carToGetById;
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
