using System;

namespace Grootest_Getal_Oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Number!");

            int x = 0;
            int y = 0;
            int highest = 0;
            do
            {
                y = y + x;


                Console.WriteLine("Enter integer values ​​(32767 = stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);

                if (x != 32767 && highest < x)
                    
                {
                    highest = x;
                    Console.WriteLine("out of all values highest number is:" + (x));

                }

            } while (x != 32767);
            Console.WriteLine($"Sum is {y}");
        }
    }
}
