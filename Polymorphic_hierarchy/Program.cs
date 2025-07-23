using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle;

            myVehicle = new Car();
            myVehicle.StartEngine();  // Output: Car engine started with a smart key.

            myVehicle = new Bike();
            myVehicle.StartEngine();  // Output: Bike engine started with a kick.

            myVehicle = new Truck();
            myVehicle.StartEngine();  // Output: Truck engine started with a heavy-duty switch.
        }
    }
}
