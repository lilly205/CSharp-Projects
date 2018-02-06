using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Line
    {
        private double a;
        private double b;
        private double c;
        private double? slope= null;

        public double DetermineA
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double DetermineB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double DetermineC
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public double? Slope
        {
            get
            {
                return slope;
            }
            set
            {
                slope = value;
            }
        }


        public void DetermineX(double y)
        {
            double tempC = c - (b * y);
            Console.WriteLine("X value is: {0}", tempC / a);
        }

        public void DetermineY(double x)
        {
            double tempC = c - (a * x);
            Console.WriteLine("Y value is: {0}", tempC / b);
        }


        public void DetermineSlope()
        {
            if (a != 0)
            {
                if (b != 0)
                {
                    Slope = (-a) / b;
                    if (a>0)
                    {
                        if (b<0)
                        {
                            Console.WriteLine("Slope is: {0}/{1} OR {2}/1", a, -b, slope);
                        }
                        else
                        {
                            Console.WriteLine("Slope is: {0}/{1} OR {2}/1", -a, b, slope);
                        }
                    }
                    else if (a<0)
                    {
                        if (b<0)
                        {
                            Console.WriteLine("Slope is: {0}/{1} OR {2}/1", a, -b, slope);
                        }
                        else
                        {
                            Console.WriteLine("Slope is: {0}/{1} OR {2}/1", -a, b, slope);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Line is a vertical line!");
                }
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Line is not a line!");
                }
                else
                {
                    Console.WriteLine("Line is a horizontal line!");
                }
            }
        }
    }
}
