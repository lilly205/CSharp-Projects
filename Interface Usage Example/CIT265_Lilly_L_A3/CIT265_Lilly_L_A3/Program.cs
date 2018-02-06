using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vessel[] vessels = new Vessel[6];
            Ship ship1 = new Ship(20, "The Black Cat");
            Boat boat1 = new Boat(1, "Spelunker");
            Ship ship2 = new Ship(50, "The Black Pearl", 150, 150);
            Boat boat2 = new Boat(1, "The ShipWreck", 5);
            Ship ship3 = new Ship(25, "El Diablo", 15);
            Boat boat3 = new Boat(2, "The Speed Demon", 20);

            vessels[0] = ship1;
            vessels[1] = boat1;
            vessels[2] = ship2;
            vessels[3] = boat2;
            vessels[4] = ship3;
            vessels[5] = boat3;

            Cat cat1 = new Cat("Marble", 24);
            Cat cat2 = new Cat("Mushroom", 99);

            foreach (Vessel element in vessels)
            {
                element.Move();
            }

            Console.WriteLine();

            foreach (Vessel element in vessels) //demonstrates that vessels[4] has no more fuel
            {
                element.Move();
            }

            Console.WriteLine();

            Console.WriteLine("{0} is {1}% full!", cat1.Name, cat1.FuelPercentage);
            cat1.Refill(10);
            Console.WriteLine("After eating, {0} is now {1}% full!", cat1.Name, cat1.FuelPercentage);

            Console.WriteLine();

            Console.WriteLine("{0} is {1}% full!", cat2.Name, cat2.FuelPercentage); //demonstrates different ammounts feed cats differently
            cat2.Refill(15);
            Console.WriteLine("After eating, {0} is now {1}% full!", cat2.Name, cat2.FuelPercentage);

            Console.WriteLine();

            Console.WriteLine("{0} has {1}% fuel left!", ship1.Name, ship1.FuelPercentage);
            ship1.Refill(10);
            Console.WriteLine("After refueling, {0} now has {1}% fuel left!", ship1.Name, ship1.FuelPercentage);

            Console.WriteLine();

            Console.WriteLine("{0} has {1}% fuel left!", ship3.Name, ship3.FuelPercentage); // demonstrates it's impossible to go over 100% fuel
            ship3.Refill(150);
            Console.WriteLine("After refueling, {0} now has {1}% fuel left!", ship3.Name, ship3.FuelPercentage);

            Console.WriteLine();
        }
    }
}
