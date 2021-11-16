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

            int secretNum = new Random().Next(1, 101);
            

            for(int i = 3; i > 0; i--) {

            int attempt = 0;
            attempt = Convert.ToInt32(i);

            if( answer != secretNum ){
                Console.WriteLine($"{attempt} Guesses Left! Try again!");
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

// Phase 6
// if (secretNum == input) {
//     Console.WriteLine("correct");
//     break;
// }
// else if (secretNum > input)
//     Console.WriteLine("too low!")
// {
// else if (secretNum < input) {
//     Console.WriteLine("too high!")
// }
// }



