using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " Model üretim yılı : " + car.ModelYear + " Güncel fıyat: "+ car.DailyPrice + " Araç açıklaması :" + car.Description);
            }
        }
    }
}