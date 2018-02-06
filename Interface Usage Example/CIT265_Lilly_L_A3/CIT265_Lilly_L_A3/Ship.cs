using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    class Ship : Vessel, IRefillable
    {
        private int fuel;
        private int maxFuel;

        public Ship(float shipSpeed, string shipName, int shipFuel = 100, int shipMaxFuel = 100)
            : base(shipSpeed, shipName)
        {
            Fuel = shipFuel;
            MaxFuel = shipMaxFuel;
        }

        public int Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                fuel = value;
            }
        }

        public int MaxFuel
        {
            get
            {
                return maxFuel;
            }
            set
            {
                maxFuel = value;
            }
        }
        
        public override void Move()
        {
            if (fuel > 0)
            {
                Console.WriteLine("{0} moves at the speed {1}", base.Name, base.Speed);
                fuel -= 20;
                if (fuel <0)
                {
                    fuel = 0;
                }
            }
            else
            {
                Console.WriteLine("{0} has no fuel to move!", base.Name);
            }
        }

        public float FuelPercentage 
        {
            get
            {
                return ((float)Fuel / (float)MaxFuel) *100;
            }
        }

        public void Refill(int amt)
        {
            if (Fuel+amt <=MaxFuel)
            {
                Fuel = Fuel + amt;
            }
            else
            {
                Fuel = MaxFuel;
            }
        }
    }
}
