using System;

namespace Rna_Transcroption__Oef_
{
    class Program
    {
        
           public static void Main1(string []args)
            {
             Console.WriteLine($"Enter the charecter");

            //char[] DNA = [5]; // declair array
            char DNA = 'A';

            //   for (int i = 0; i < 5; i++)
            //   { 
            //   DNA[i] = Convert.ToChar(Console.ReadLine());
            //     }
            Console.WriteLine();
                   
                switch (DNA)
                {
                    case 'G':
                        Console.WriteLine("C");

                    break;
                    case 'C':
                        Console.WriteLine("G");

                        break;
                    case 'T':
                        Console.WriteLine("A");

                        break;
                    case 'A':
                        Console.WriteLine("U");

                        break;

                default:
                    Console.WriteLine();

                    break;
                }




            }
        }
    }

    