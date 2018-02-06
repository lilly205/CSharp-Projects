using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    class Cat : IRefillable
    {
        private int hunger;
        private int maxHunger;
        private string name;

        public Cat(string catName, int catHunger = 0, int catMaxHunger = 100)
        {
            Name = catName;
            Hunger = catHunger;
            MaxHunger = catMaxHunger;
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

        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        public int MaxHunger
        {
            get
            {
                return maxHunger;
            }
            set
            {
                maxHunger = value;
            }
        }

        public float FuelPercentage
        {
            get
            {
                return (((float)MaxHunger - (float)Hunger) / (float)MaxHunger) *100;
            }
        }

        public void Refill(int amt)
        {
            if (Hunger - amt >= 0)
            {
                Hunger = Hunger - amt;
            }
            else
            {
                Hunger = 0;
            }

        }
    }
}
