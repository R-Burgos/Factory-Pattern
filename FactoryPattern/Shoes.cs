using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Shoes : IVehicle
    {
        public Shoes()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Wow.. you either entered zero or some ridiculously large number for the amount of tires...");
            Console.WriteLine($"Building a new pair of {GetType().Name.ToLower()}!");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine("..");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine($"Enjoy your {GetType().Name.ToLower()}. They are Skechers, get to stepping sucker.");
        }
    }
}
