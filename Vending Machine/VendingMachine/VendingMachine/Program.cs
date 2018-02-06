using System;


namespace VendingMachineAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendor Machine = new Vendor();
            Items chips = new Items(1.25, "Bag of Chips", 1);
            Machine[0] = chips;
            Items chocolate = new Items(1.50, "Chocolate", 0);
            Machine[1] = chocolate;
            Items energyDrink = new Items(2.50, "Energy Drink", 10);
            Machine[2] = energyDrink;
            Items nutritionBar = new Items(1.00, "Nutrition Bar", 20);
            Machine[3] = nutritionBar;
            Items pretzels = new Items(1.25, "Bag of Pretzels", 5);
            Machine[4] = pretzels;


            while (Machine.GetItemsLeft()>0) // as long as the machine has at least one item
            {
                int index;
                int numItems;
                Machine.printInventory();
                Console.WriteLine("Please press the corresponding position to buy your item! (Press any non numeric key to exit)");
                if (int.TryParse(Console.ReadLine(), out index) != true) // checks if input can be changed to an int
                {
                    return;
                }    
                while (index < 1 || index > 5) // if it does check out but is over 5 or under 1 then retry until input is allowed
                { 
                    Console.WriteLine("Invalid input! Try again! (Press any non numeric key to exit)");
                    if (int.TryParse(Console.ReadLine(), out index) != true)
                    {
                        return;
                    }
                }
                Console.WriteLine("How many would you like to buy? (Press any non numeric key to exit)");
                if (int.TryParse(Console.ReadLine(), out numItems) != true)
                {
                    return;
                }
                Machine.buyItem(index-1, numItems);
            }
        }
    }
}
