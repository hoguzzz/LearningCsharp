using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ListCarManager : IListCarService
    {
        public void ListCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.CarId + " " + car.ModelYear + " Model " + car.CarDescription + " " + car.DailyPrice + " Fiyatındadır.");
            }
        }
    }
}
