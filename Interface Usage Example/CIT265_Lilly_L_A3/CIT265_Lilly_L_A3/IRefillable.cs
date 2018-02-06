using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Lilly_L_A3
{
    interface IRefillable
    {
        float FuelPercentage{get;}
        void Refill(int amt);
    }
}
