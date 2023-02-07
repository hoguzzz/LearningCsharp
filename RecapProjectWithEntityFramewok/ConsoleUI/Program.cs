using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Drawing;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " "+ car.CarDescription);
            }
            carManager.AddCar(new Car { CarId = 102, BrandId = 11, ColorId = 7, DailyPrice = 0, CarDescription = "Citroen C-Elysee", ModelYear = "2013" });
            Console.WriteLine("Eklendikten sonra");
            foreach (var item in carManager.GetAllByBrandId(11))
            {
                Console.WriteLine(item.CarId + " " + item.CarDescription);
            }
        }
    }
}