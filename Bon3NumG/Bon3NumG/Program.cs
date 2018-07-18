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

            Random CreateNum = new Random();

            while (Repeat)

            {//generate number
                
                ActNum = CreateNum.Next(1, 101);

                //ask for input
                Console.WriteLine("I gotta number, can you guess which one?");
                WrongNum = true;
                while (WrongNum)
                {
                    Guess = Int32.Parse(Console.ReadLine());

                    if(Guess != ActNum)
                    {
                        if(Guess - ActNum < 10)
                        {
                            Console.WriteLine("Close, but still high");
                        }
                        else if (Guess > ActNum)
                        {
                            Console.WriteLine("Too High");
                        }
                        else if (ActNum - Guess < 10)
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
    }
}
