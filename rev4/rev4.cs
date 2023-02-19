//Name: Hamza Paracha
//Assignment: Review 4
//Date: February 19
//Description: you will input some characteristics of an alien that was sighted and the program will output the sighted alien name, using a list and indexing. and a t list it adds it to the mutable list and prints that.     
using System;

class Program3
{
    static void Main()
    {
        int antenna, eyes;
        Console.Write("Enter the number of antenna(s): ");
        antenna = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of eyes: ");
        eyes = Convert.ToInt32(Console.ReadLine());

        //this is used to manipulate lists and to find index
        var matchingAliens = new System.Collections.Generic.List<string>();

        // Check if the alien matches TroyMartians description
        if (antenna >= 3 && eyes <= 4)
        {
            matchingAliens.Add("TroyMartian");
        }

        // Check if the alien matches VladSaturnians description
        if (antenna <= 6 && eyes >= 2)
        {
            matchingAliens.Add("VladSaturnian");
        }

        // Check if the alien matches GraemeMercurian's description
        if (antenna <= 2 && eyes <= 3)
        {
            matchingAliens.Add("GraemeMercurian");
        }

        // Output the matching aliens
        if (matchingAliens.Count > 0)
        {
            Console.WriteLine("The witness saw an alien that matches the description of:");
            foreach (string alien in matchingAliens)
            {
                Console.WriteLine(alien);
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("No aliens match the description.");
            Console.ReadKey();
        }
    }
}
