using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Watch out, Sons of Anarchy coming through.");
            Console.WriteLine($"Building a new {GetType().Name}!");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine("..");
            Thread.Sleep(500);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine($"Enjoy your {GetType().Name.ToLower()}... oh you thought it was going to be a REAL {GetType().Name.ToLower()}...oh boy. YIKES");
        }
    }
}
