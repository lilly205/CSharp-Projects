using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LillyL_CIT265_A4
{
    class Player
    {
        private Random random1 = new Random();
        private int id=1;
        private int wins=0;
        private int losses=0;
        private string name;
        private enum actions { Sword, Spear, Cavalry};

        public Player (int uID, string uName)
        {
            ID = uID;
            Name = uName;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins += value;
            }
        }
        public int Losses
        {
            get
            {
                return losses;
            }
            set
            {
                losses += value;
            }
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

        public void PlayGame(Player other)
        {
            if (ID != other.ID)
            {
                var v = Enum.GetValues(typeof(actions));
                
                actions p1 = (actions)v.GetValue(random1.Next(v.Length));
                actions p2 = (actions)v.GetValue(random1.Next(v.Length));
                

                switch (p1)
                {
                    //Player 1 chooses cavalry
                    case actions.Cavalry:
                        {
                            switch (p2)
                            {
                                // Compares Player 1's choice to Player 2's. If it's the same, rematch.
                                case actions.Cavalry:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. It's a tie! Rematch.", Name, p1.ToString(), other.Name, p2.ToString());
                                        PlayGame(other);
                                        break;
                                    }
                                case actions.Spear:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), other.Name);
                                        other.Wins = 1;
                                        Losses = 1;
                                        break;
                                    }
                                case actions.Sword:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), Name);
                                        Wins = 1;
                                        other.Losses = 1;
                                        break;
                                    }
                            }
                            break;
                        }
                    //Player 1 chooses spear
                    case actions.Spear:
                        {
                            switch (p2)
                            {
                                // Compares Player 1's choice to Player 2's. If it's the same, rematch.
                                case actions.Cavalry:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), Name);
                                        Wins = 1;
                                        other.Losses = 1;
                                        break;
                                    }
                                case actions.Spear:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. It's a tie! Rematch.", Name, p1.ToString(), other.Name, p2.ToString());
                                        PlayGame(other);
                                        break;
                                    }
                                case actions.Sword:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), other.Name);
                                        other.Wins = 1;
                                        Losses = 1;
                                        break;
                                    }
                            }
                            break;
                        }
                    //Player 1 chooses sword
                    case actions.Sword:
                        {
                            switch (p2)
                            {
                                // Compares Player 1's choice to Player 2's. If it's the same, rematch.
                                case actions.Cavalry:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), other.Name);
                                        other.Wins = 1;
                                        Losses = 1;
                                        break;
                                    }
                                case actions.Spear:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. {4} wins!", Name, p1.ToString(), other.Name, p2.ToString(), Name);
                                        Wins = 1;
                                        other.Losses = 1;
                                        break;
                                    }
                                case actions.Sword:
                                    {
                                        Console.WriteLine("{0} chose {1}. {2} chose {3}. It's a tie! Rematch.", Name, p1.ToString(), other.Name, p2.ToString());
                                        PlayGame(other);
                                        break;
                                    }
                            }
                            break;
                        }
                }

                return;
            }
        }

    }
}
