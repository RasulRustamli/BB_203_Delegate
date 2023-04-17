namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 234);
            Car car2 = new Car("Toyota", 234);
            Car car3 = new Car("Nissan", 234);
            Car car4 = new Car("Hyundai", 234);
            Car car5 = new Car("Mercedes", 234);
            Car car6 = new Car("Lada", 234);

            Galery galery = new Galery();
            galery.AddCar(car);
            galery.AddCar(car2);
                
            galery.AddCar(car3);
                
            galery.AddCar(car4);
            galery.AddCar(car5);
            galery.AddCar(car6);
            string input = Console.ReadLine();
            Console.WriteLine(galery.FindCar(x => x.CarCode==input||x.Id.ToString()==input).Name);

            //foreach (var item in galery.GetAllCars(x=>x.Id>1002))
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}