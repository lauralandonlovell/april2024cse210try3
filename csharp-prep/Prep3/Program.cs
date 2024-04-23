using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World!");
        string response = "yes".ToLower();
        int guess = -1;
        Random randomNumber = new();
        int magicNumber = randomNumber.Next(1, 101);
        Console.WriteLine(magicNumber);
        
        Console.WriteLine("Guess a number between 1 and 100: ");
        guess = int.Parse(Console.ReadLine());

        do
        {
           //need some exception handling for accidental text responses like "yes"
           if(magicNumber > guess)
           {
                Console.WriteLine("Guess higher!");     
           }
           else if (magicNumber < guess)
           {
            Console.WriteLine("Guess lower!");
           }
           else if (guess == magicNumber)
           {
            Console.WriteLine("Congratulations! You guessed it!");
            Console.WriteLine("Would you like to play again?");
            response = Console.ReadLine();
                if (response != "yes")
                break;
           }
            Console.WriteLine("Would you like to continue playing? ");
            response = Console.ReadLine();
        
        }while(response == "yes");
        
                        
    }
}
