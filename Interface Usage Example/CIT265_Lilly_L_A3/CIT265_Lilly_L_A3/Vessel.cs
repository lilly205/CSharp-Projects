using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    public abstract class Vessel
    {
        private float speed;
        private string name;

        public Vessel(float shipSpeed, string shipName)
        {
            Speed = shipSpeed;
            Name = shipName;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public abstract void Move();
    }
}
