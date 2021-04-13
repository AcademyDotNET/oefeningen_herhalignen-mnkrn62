using System;

namespace Euler_project_oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eular Project App!");
            int z = 0;
            Console.WriteLine();
            for (int i = 0; i <= 1000; i++)
            {

                if (i % 3 == 0 || i % 5 == 0 )  
                {
                    z += i;
                }
                
            }
            Console.WriteLine(z);
        }
    }
}
