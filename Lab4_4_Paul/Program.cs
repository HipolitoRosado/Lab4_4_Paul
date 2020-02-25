using System;

namespace Lab4_4_Paul
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] blackListWord = {"viagra", "buy", "XXX", "free money",
            "lifetime offer", "send money", "bank account", "nigeria", "onlinepharmacy", "h8te", "meet girls" };
            

            string message = Console.ReadLine();
            message = message.ToLower();
            Console.WriteLine(message);
            bool isSpam = false;
            for (int i = 0; i < blackListWord.Length; i++)
            {
                if (message.Contains(blackListWord[i]))
                {
                    isSpam = true;

                }
            }
               if(isSpam == true)
            {
                Console.WriteLine("The message contains a spam");
            }
                
                    else
                {
                    Console.WriteLine("The message is not spam.");
                }

            }
        }
        
    }

   