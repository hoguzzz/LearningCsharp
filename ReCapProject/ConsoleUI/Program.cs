using Business.Concrete;
using DataAccess.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            ListCarManager listCarManager = new ListCarManager();
            listCarManager.ListCars(carManager.GetCars());
            Console.WriteLine("********Id ile getirilen *********");
            listCarManager.ListCars(carManager.GetCarsById(5));
        }
    }
}