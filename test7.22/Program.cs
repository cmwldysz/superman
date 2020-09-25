using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._22
{
    abstract class Factory
    {
        string name;

        public string getName() { 
            return name;
        }
        public void setName(string name) {
            this.name = name;
        }

        public abstract string produce();
    }
    class CarFactory : Factory {
        public string carName;
        public CarFactory(string name) {
            this.carName = name;
        }
        public override string produce()
        {
            return this.carName;
        }
    }
    class ShoeFactory : Factory
    {
        public string shoeName;
        public ShoeFactory(string name)
        {
            this.shoeName = name;
        }
        public override string produce()
        {
            return this.shoeName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory car = new CarFactory("汽车厂");
            car.setName("汽车");
            ShoeFactory shoe = new ShoeFactory("鞋厂");
            shoe.setName("鞋");
            Console.WriteLine(car.produce() + "生产的是 " + car.getName());
            Console.WriteLine(shoe.produce() + "生产的是 " + shoe.getName());
            Console.ReadKey();
        }
    }
}
