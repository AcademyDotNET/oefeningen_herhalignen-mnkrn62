using System;


namespace Rna_Transcroption__Oef_
{
    class AnotherWay
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Please enter the DNA string"); 
            //char DNA = Convert.ToChar(Console.ReadLine());
            string DNA = Console.ReadLine();
            Char[] DNAArray = DNA.ToCharArray();

            // ACGTGGTCTTAA --> UGCACCAGAAUU.
            string output = "";
            for (int i = 0; i < DNAArray.Length; i++)
            {
                Char ch = DNAArray[i]; 

                switch (ch)
                {
                    case 'G':
                        //Console.WriteLine("C");
                        output = output + "C";
;
                        break;
                    case 'C':
                        //Console.WriteLine("G");
                        output = output + "G";

                        break;
                 
                    case 'T':
                       // Console.WriteLine("A");
                        output = output + "A";

                        break;
                    case 'A':
                        // Console.WriteLine("U");
                        output = output + "U";
                        
                        break;

                    default:
                        output = output + "0";
                        break;

                }// end of Switch

            }//end of for look


            Console.WriteLine(output);
            Console.ReadLine();

            //switch (DNA)
            //{
            //    case 'G':
            //        Console.WriteLine("C");

            //        break;
            //    case 'C':
            //        Console.WriteLine("G");

            //        break;
            //    case 'T':
            //        Console.WriteLine("A");

            //        break;
            //    case 'A':
            //        Console.WriteLine("U");

            //        break;

            //    case 'ACGTGGTCTTAA':
            //        Console.WriteLine("UGCACCAGAAUU");

            //        break;


            //    default:
            //        break;

            //        Console.ReadLine();

            //        // string DNA1 = Convert.ToInt32(Console.ReadLine());
            //        //string DNA1 = Console.ReadLine();
            //}
        }

    }
}
