using System;



namespace Assignment1
{
    class Program
    {
        static void CompareLines(Line A, Line B)
        {
            bool parallel=true;
            if (A.Slope.HasValue == true && B.Slope.HasValue == true)
            {
                if (A.Slope * B.Slope == -1)
                {
                    Console.WriteLine("Line A and Line B are perpendicular!");
                    parallel = false;
                }
                else if (A.Slope == B.Slope)
                {
                    Console.WriteLine("Line A and Line B are parallel!");
                }
                else
                {
                    Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                    parallel = false;
                }
            }
            else if (A.Slope.HasValue!=true && B.Slope.HasValue!=true)
            {
                if (A.DetermineA == 0 && A.DetermineB != 0)
                {
                    if (B.DetermineA != 0 && B.DetermineB == 0)
                    {
                        Console.WriteLine("Line A and Line B are perpendicular!");
                        parallel = false;
                    }
                    else if (B.DetermineA == 0 && B.DetermineB!= 0)
                    {
                        Console.WriteLine("Line A and Line B are parallel!");
                    }
                    else
                    {
                        Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                    }
                }
                else if (A.DetermineA!= 0 && A.DetermineB==0)
                {
                    if (B.DetermineA==0 && B.DetermineB!=0)
                    {
                        Console.WriteLine("Line A and Line B are perpendicular!");
                        parallel = false;
                    }
                    else if (B.DetermineA!=0 && B.DetermineB == 0)
                    {
                        Console.WriteLine("Line A and Line B are parallel!");
                    }
                    else
                    {
                        Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                    }
                }
                else
                {
                    Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                }
            }
            else if (A.Slope.HasValue!=true && B.Slope.HasValue==true)
            {
                Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                parallel = false;
            }
            else if (A.Slope.HasValue==true && B.Slope.HasValue!=true)
            {
                Console.WriteLine("Line A and Line B are not parallel or perpendicular!");
                parallel = false;
            }

            if (parallel == false)
            {
                Console.WriteLine();
                double localA1, localB1, localC1, localA2, localB2, localC2;
                double intersectX, interesectY;
                //Convert to slope intercept form
                localA1 = (-(A.DetermineA) / A.DetermineB);
                localB1 = A.DetermineB/A.DetermineB;
                localC1 = A.DetermineC / A.DetermineB;
                Console.WriteLine("y = {0}x + {1}", localA1, localC1);

                localA2 = (-(B.DetermineA) / B.DetermineB);
                localB2 = B.DetermineB / B.DetermineB;
                localC2 = B.DetermineC / B.DetermineB;
                Console.WriteLine("y = {0}x + {1}", localA2, localC2);

                localA2 = localA2 - localA1;
                localC2 = localC1 - localC2;
                intersectX = localC2 / localA2;
                

                interesectY = (localA1 * intersectX) + localC1;

                Console.WriteLine("Intersection found at: ({0}, {1})!", intersectX, interesectY);
                Console.WriteLine();
            }


        }

        static void Main(string[] args)
        {
            Line line1 = new Line();
            line1.DetermineA = 8;
            line1.DetermineB = 4;
            line1.DetermineC = 16;
            line1.DetermineX(3);
            line1.DetermineY(3);
            line1.DetermineSlope();

            Console.WriteLine();

            Line line2 = new Line();
            line2.DetermineA = -4;
            line2.DetermineB = 8;
            line2.DetermineC = 4;
            line2.DetermineX(3);
            line2.DetermineY(3);
            line2.DetermineSlope();

            Console.WriteLine();

            CompareLines(line1, line2);
         }
    }
}

