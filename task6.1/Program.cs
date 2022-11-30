using System;
namespace FactoryMethodExample
{
    // "Creator"
    public abstract class Factory
    {
        public abstract Vehicle MakeProduct(int type);
    }

    // "ConcreteCreator"
    public class VehicleFactory : Factory
    {
        public override Vehicle MakeProduct(int type)
        {
            switch (type)
            {
                //повертає об'єкт A, якщо type==1
                case 1: return new Car();
                //повертає об'єкт B, якщо type==2  
                case 2: return new Bike();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }

    // "Product"
    public abstract class Vehicle 
    {
        public abstract void Move();
    }

    // "ConcreteProductA"
    public class Car : Vehicle 
    {
        public override void Move()
        {
            Console.WriteLine("");
        }
    }

    // "ConcreteProductB"
    public class Bike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("");
        }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Factory creator = new VehicleFactory();
            for (int i = 1; i <= 2; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = creator.MakeProduct(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}

