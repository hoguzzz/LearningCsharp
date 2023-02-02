using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId = 1,BrandId = 1, ColorId = 2, ModelYear = "2007",DailyPrice = 150000,CarDescription = "Renault Clio"},
                new Car{CarId = 2,BrandId = 2, ColorId = 2, ModelYear = "2016",DailyPrice = 350000,CarDescription = "Volkswagen Golf"},
                new Car{CarId = 3,BrandId = 2, ColorId = 1, ModelYear = "2022",DailyPrice = 600000,CarDescription = "Volkswagen Golf"},
                new Car{CarId = 4,BrandId = 3, ColorId = 3, ModelYear = "2008",DailyPrice = 165000,CarDescription = "Opel Astra"},
                new Car{CarId = 5,BrandId = 4, ColorId = 3, ModelYear = "2013",DailyPrice = 230000,CarDescription = "Citroen C-Elysee"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
