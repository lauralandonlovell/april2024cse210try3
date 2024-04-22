using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            Console.WriteLine("Your grade is an A!");
        }
        else if (percentage >= 80 && percentage < 90)
        {
            Console.WriteLine("Your grade is a B!");
        }
        else if (percentage >= 70 && percentage < 80)
        {
            Console.WriteLine("Your grade is a C!");
        }
        else if (percentage >= 60 && percentage < 70)
        {
            Console.WriteLine("Your grade is a D!");
        }
        else 
        {
            Console.WriteLine("Your grade is an F.");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        } 
        else if (percentage < 70)
        {
            Console.WriteLine("You didn't pass!");
        }

        






       
    }
}