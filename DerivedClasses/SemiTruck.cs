using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClasses
{
    class SemiTruck : Vehicle
    {

        private int maxPayLoad; 

        public SemiTruck(int maxPayLoad)
        {
            Seats = 2;
            Wheels = 18;
            hornVolume = 30.0;
            this.maxPayLoad = maxPayLoad;
        }

        public void Display()
        {
            Console.WriteLine("Seats: {0}, Wheels: {1}, Horn Volume: {2}, Max Payload is {3} Ibs", Seats, Wheels, hornVolume, maxPayLoad);
        }
    }
}
