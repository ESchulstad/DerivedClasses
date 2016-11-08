using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClasses
{
    class Vehicle
    {

        private int numberOfWheels;

        public int Wheels
        {
            get { return this.numberOfWheels; }
            set { numberOfWheels = value; }
        }

        private int numberOfSeats;

        public int Seats
        {
            get { return this.numberOfSeats; }
            set { numberOfSeats = value; }
        }

        protected double hornVolume;


    }
}
