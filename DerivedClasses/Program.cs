﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Car celica = new Car();

            celica.Display();

            SemiTruck mac = new SemiTruck(24000);

            mac.Display();
        }
    }
}
