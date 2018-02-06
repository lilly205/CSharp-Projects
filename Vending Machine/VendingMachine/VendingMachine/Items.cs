using System;

namespace VendingMachineAssignment
{
    class Items
    {
        private double price;
        private string name;
        private int quantity;

        public Items(double price, string name, int quantity)
        {
            ItemPrice = price;
            ItemName = name;
            ItemQuantity = quantity;
        }
       
        public double ItemPrice
        { 
          get
               {
                return price;
               } 
          set
              {
                price = value;
              }         
        }
        public string ItemName
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
        public int ItemQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}
