using System;

namespace Steen_schaar_Oef
{
    class Program
    {
        static void Main(string[] args)
        {
            // declair variables
            int userinput = 0;
            int userscore = 0;
            int pcscore = 0;
            int randomnum = 0;
            while ((userscore < 10) && (pcscore < 10))
            {
                Console.WriteLine ("choose one nunber = Rock(1), Scissor(2), Paper(3)");
                
                userinput = int.Parse(Console.ReadLine());
                Random nr = new Random();
                randomnum = nr.Next(1, 3);
                Console.WriteLine ($"PC input is : {randomnum}");
                if (userinput == randomnum)
                {
                    Console.WriteLine("Nobody wins");
                }
                else if ((userinput < randomnum) && ((userinput!=1) || (randomnum!=3)))
                {
                    userscore = userscore + 1;
                    Console.WriteLine($"User win 1 point, user total score is: {userscore}");
                }
                else
                {
                    pcscore = pcscore + 1;
                    Console.WriteLine($"PC win 1 point, PC total score is: {pcscore}");
                }
                }
            if (userscore == 10)
            {
                Console.WriteLine("User win the game with 10 points");
            }
            else
            {
                Console.WriteLine("PC win the game");
            }
        }
    }
}
