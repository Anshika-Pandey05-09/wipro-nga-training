using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_hierarchy
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting the vehicle engine...");
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with a smart key.");
        }
    }

    // Derived class: Bike
    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with a kick.");
        }
    }

    // Derived class: Truck
    public class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started with a heavy-duty switch.");
        }
    }
}
