//Name: Hamza Paracha
//Assignment: Review 2 Program 1
//Date: February 13
//Description: you enter an input of the votes. the program will go through the string and read each letter and add it to an int to find out which variable has a higher value, which means more votes. 
using System;
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the vote results (a and b only):");
        string votes = Console.ReadLine();
        //declare and give variables a value
        int countA = 0;
        int countB = 0;
        //for each statement to go through the string of votes. 
        foreach (char vote in votes)
        {
            if (vote == 'a')
            {
                countA++;
            }
            else if (vote == 'b')
            {
                countB++;
            }
        }
        //prints the total votes sorted from the for each statement.
        Console.WriteLine("Singer A received " + countA + " votes.");
        Console.WriteLine("Singer B received " + countB + " votes.");
        //if statement to find which value is greater. 
        if (countA > countB)
        {
            Console.WriteLine("Singer A wins with " + countA + " votes.");
        }
        else if (countB > countA)
        {
            Console.WriteLine("Singer B wins with " + countB + " votes.");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }

        Console.ReadLine();
    }
}