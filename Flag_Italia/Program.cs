using System;

namespace FlagItalia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of floors:");
            int Floors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of flats on the floor:");
            int FlatsOnTheFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of padiks:");
            int Padiks = Convert.ToInt32(Console.ReadLine());

            for (int f = Floors; f > 0; f--)
            {
                Console.WriteLine();
                for (int p = 1; p <= Padiks; p++)
                {
                    var FlatNumber = f * FlatsOnTheFloor + (Floors * (p - 1) * FlatsOnTheFloor) - FlatsOnTheFloor;
                    var Wideline = (Padiks - Padiks % 3) / 3;
                    for (int k = 1; k <= FlatsOnTheFloor; k++)
                    {
                        FlatNumber++;
                        {
                            if (FlatNumber <= Floors * FlatsOnTheFloor * Wideline)
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            else if (FlatNumber > Floors * FlatsOnTheFloor * Wideline && FlatNumber <= Floors * FlatsOnTheFloor * (Wideline * 2))
                                Console.ForegroundColor = ConsoleColor.White;

                            else if (FlatNumber > Floors * FlatsOnTheFloor * (Wideline * 2) && FlatNumber <= Floors * FlatsOnTheFloor * (Wideline * 3))
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                        }

                        Console.Write("{0,5}", FlatNumber);


                    }
                    Console.Write("|");
                }
            }
        }
    }
}
