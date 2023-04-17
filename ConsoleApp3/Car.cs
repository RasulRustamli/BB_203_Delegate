using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car
    {
        private static int _id = 1000;
        public int Id { get; set; }
        public string Name { get; set; }
        public string CarCode { get; set; }
        public int Speed { get; set; }
        public Car(string name,int speed)
        {
            _id++;
            Id= _id;
            Name = name;
            Speed = speed;
            CarCode = Name.Substring(0, 2).ToUpper() + Id;
        }
    }
}
