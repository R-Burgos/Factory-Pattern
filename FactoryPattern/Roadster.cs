﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Roadster : IVehicle
    {
        public Roadster()
        {

        }

        public void Drive()
        {
            Console.WriteLine("Cool a motorcycle with training wheels...");
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