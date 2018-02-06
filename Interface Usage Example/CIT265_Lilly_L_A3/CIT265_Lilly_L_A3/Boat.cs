using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    class Boat : Vessel
    {
        private int oars;

        public Boat(float shipSpeed, string shipName, int boatOars = 10)
            : base(shipSpeed, shipName)
        {
            Oars = boatOars;
        }

        public int Oars
        {
            get
            {
                return oars;
            }
            set
            {
                oars = value;
            }
        }

        public override void Move()
        {
                Console.WriteLine("{0} moves at the speed {1}", base.Name, base.Speed*Oars);
        }
    }
}
