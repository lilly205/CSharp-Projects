using System;


namespace VendingMachineAssignment
{
    class Vendor
    {
        private Items[] inventory = new Items[5];
        private int itemsLeft = 0;


        public Vendor()
        {
            //http://www.angelfire.com/co/cajhnesplace/ascii/vend.html
            Console.WriteLine(" ____________________________________________ ");
            Console.WriteLine(@"|############################################|");
            Console.WriteLine(@"|#|                           |##############|");
            Console.WriteLine(@"|#|  =====  ..--''`  |~~``|   |##|````````|##|");
            Console.WriteLine(@"|#|  |   |  \     |  :    |   |##| Exact  |##|");
            Console.WriteLine(@"|#|  |___|   /___ |  | ___|   |##| Change |##|");
            Console.WriteLine(@"|#|  /=__\  ./.__\   |/,__\   |##| Only   |##|");
            Console.WriteLine(@"|#|  \__//   \__//    \__//   |##|________|##|");
            Console.WriteLine(@"|#|===========================|##############|");
            Console.WriteLine(@"|#|```````````````````````````|##############|");
            Console.WriteLine(@"|#| =.._      +++     //////  |##############|");
            Console.WriteLine(@"|#| \/  \     | |     \    \  |#|`````````|##|");
            Console.WriteLine(@"|#|  \___\    |_|     /___ /  |#| _______ |##|");
            Console.WriteLine(@"|#|  / __\\  /|_|\   // __\   |#| |1|2|3| |##|");
            Console.WriteLine(@"|#|  \__//-  \|_//   -\__//   |#| |4|5|6| |##|");
            Console.WriteLine(@"|#|===========================|#| |7|8|9| |##|");
            Console.WriteLine(@"|#|```````````````````````````|#| ``````` |##|");
            Console.WriteLine(@"|#| ..--    ______   .--._.   |#|[=======]|##|");
            Console.WriteLine(@"|#| \   \   |    |   |    |   |#|  _   _  |##|");
            Console.WriteLine(@"|#|  \___\  : ___:   | ___|   |#| ||| ( ) |##|");
            Console.WriteLine(@"|#|  / __\  |/ __\   // __\   |#| |||  `  |##|");
            Console.WriteLine(@"|#|  \__//   \__//  /_\__//   |#|  ~      |##|");
            Console.WriteLine(@"|#|===========================|#|_________|##|");
            Console.WriteLine(@"|#|```````````````````````````|##############|");
            Console.WriteLine(@"|############################################|");
            Console.WriteLine(@"|#|||||||||||||||||||||||||||||####```````###|");
            Console.WriteLine(@"|#||||||||||||PUSH|||||||||||||####\|||||/###|");
            Console.WriteLine(@"|############################################|");
            Console.WriteLine(@"\\\\\\\\\\\\\\\\\\\\\\/////////////////////// ");
            Console.WriteLine(@" |________________________________|CR98|___|  ");

            Console.WriteLine();
        }
        public Items this[int index]
        {
            //allows setting the inventory 
            get
                {
                return inventory[index];
                }
            set
                {
                inventory[index] = value;
                itemsLeft += value.ItemQuantity; //make sure to add how many items were in the quantity so the program will know when there arent any items left
                }
        }
        
        public int GetItemsLeft()
        {
            return itemsLeft;
        }

        public void printInventory()
        {
            int count = 0;
            foreach (Items elements in inventory)
            {
                count++;
                Console.WriteLine("Inventory position: {0} is Item: {1} ${2}, {3} left", count, elements.ItemName, elements.ItemPrice.ToString("F"), elements.ItemQuantity);
            }
        }

        public void buyItem(int index, int amount)
        {
            double totalPrice=0;
            if (inventory[index].ItemQuantity > 0)
            {
                if (inventory[index].ItemQuantity - amount >=0) // if the item is bought and there are enough in stock
                { 
                inventory[index].ItemQuantity-=amount;
                itemsLeft-=amount;
                totalPrice = inventory[index].ItemPrice * amount;
                Console.WriteLine("Item bought! Now there are {0} left. Total was ${1}", inventory[index].ItemQuantity, totalPrice.ToString("F"));
                Console.WriteLine();
                }
                else //buy the remaining left
                {
                    totalPrice = inventory[index].ItemPrice * inventory[index].ItemQuantity;
                    itemsLeft -= inventory[index].ItemQuantity;
                    Console.WriteLine("There weren't enough items in stock! However you bought the remaining {0} left. Total was ${1}", inventory[index].ItemQuantity, totalPrice.ToString("F"));
                    Console.WriteLine();
                    inventory[index].ItemQuantity -= inventory[index].ItemQuantity;
                }
            }
            else // none left so none bought
            {
                Console.WriteLine("There aren't any to buy!");
                Console.WriteLine();
            }
            
        }
    }
}
