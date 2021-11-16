using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number! Any number!");
            Console.WriteLine("---------------------------");
            Console.Write($"{""}");
            int answer = int.Parse(Console.ReadLine());


            void userQuery() {

            int secretNum = 42;
            

            for(int i = 0; i < 3; i++) {

            int attempt = 0;
            attempt = Convert.ToInt32(i + 1);

            if( answer != secretNum ){
                Console.WriteLine("Attempt #" + $"{attempt} That's not it, try again!");
                answer = int.Parse(Console.ReadLine());
            }
            else 
            {
             if( answer == secretNum ){
                 Console.WriteLine("You got it!");
                 Environment.Exit(0);
             }
            }
        }
    }
         userQuery();
        }
    }
}
