using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon3NumG
{
    class Program
    {
        static void Main(string[] args)
        {
            int ActNum;
            bool WrongNum;
            int Guess;
            var Repeat = true;
            int GuessCount;

            Random CreateNum = new Random();

            while (Repeat)

            {//generate number
                GuessCount = 0;
                ActNum = CreateNum.Next(1, 101);

                //ask for input
                Console.WriteLine(ActNum);
                Console.WriteLine("I gotta number, can you guess which one?");
                WrongNum = true;
                while (WrongNum)

                {
                    Guess = Validate();
                    GuessCount++;
                    if (Guess != ActNum)
                    {

                        if (Guess - ActNum < 10 && Guess - ActNum > 0)
                        {
                            Console.WriteLine("Close, but still high");
                        }
                        else if (Guess > ActNum)
                        {
                            Console.WriteLine("Too High");
                        }
                        else if (ActNum - Guess < 10 && ActNum - Guess > 0)
                        {
                            Console.WriteLine("Close, but still low");
                        }
                        else if (Guess < ActNum)
                        {
                            Console.WriteLine("Too Low");
                        }
                    }


                    else
                    {
                        Console.WriteLine("Correct!");
                        WrongNum = false;
                        Console.WriteLine("It took " + GuessCount + " tries");
                        if (GuessCount > 10)
                        {
                            Console.WriteLine("Bad job");
                        }
                        else if (GuessCount > 5)
                        {
                            Console.WriteLine("ehhh job");
                        }
                        else
                        {
                            Console.WriteLine("good job.");
                        }
                    }
                }
                //correct?
                //Off by what?

                Repeat = Retry();

            }

        }
        //restart?
        static bool Retry()
        {
            Console.WriteLine("Continue? (y/n)");
            String Answer = Console.ReadLine().ToUpper();

            //var enteredYes = new[] { "Y", "YES" }.Contains(Answer);

            if (Answer == "Y" || Answer == "YES")
            {
                return true;

            }
            else if (Answer == "N" || Answer == "NO")
            {
                return false;

            }
            else
            {
                Console.WriteLine("IDK mang, gimme a y or n plz");
                return Retry();

            }

        }
        static int Validate()
        {
            String Input = Console.ReadLine();
            if (Int32.TryParse(Input, out int result) && result > 0 && result < 101)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Nice try, it's gotta be between 1 and 100");
                return Validate();
            }
        }
    }
}
