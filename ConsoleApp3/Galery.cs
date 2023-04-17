using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Galery
    {
        public string Name { get; set; }
        List<Car> Cars=new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public List<Car> GetAllCars(Predicate<Car> predicate)
        {
            return Cars.FindAll(predicate);
        }
        public  Car FindCar(Predicate<Car> predicate)
        {
            return Cars.Find(predicate);
        }

    }
}
