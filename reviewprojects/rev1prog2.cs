//Name: Hamza Paracha
//Assignment: Review 1 Program 2
//Date: February 10
//Description: you are buying apples from a store which the price of the apples is hardcoded. the totals and taxes are calculated by variables.

using System;

class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hamza's Apple store!" +
        "Here, we sell Apples for $2.50 each. ");
        Console.Write("How many Apples would you like to purchase?");
        int quantity = Console.ReadLine();
        //quanitity being multiplied by the price
        int subtotal = quantity * 2.5;
        Console.WriteLine("Your total cost for your apple(s) before taxes are $" + subtotal);
        //final cost is multiplied by the tax because it is 13%
        int finalcost = subtotal * 1.13;
        //difference of final total and subtotal is the tax
        int onlytax = finaltotal - subtotal;
        //print the tax
        Console.WriteLine("Tax: " + onlytax);
        Console.WriteLine("Your final total including tax is: " + finalcost);
        Console.Readkey();
    }
}
