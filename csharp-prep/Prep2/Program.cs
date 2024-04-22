using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float percentage = int.Parse(Console.ReadLine());
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        } 
        else if (percentage < 70)
        {
            Console.WriteLine("Failed! Better luck next time!");
        }








       
    }
}