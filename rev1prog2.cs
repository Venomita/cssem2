using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Welcome to Hamza's Apple store!" +
        "Here, we sell Apples for $2.50 each. ");
        Console.Write("How many Apples would you like to purchase?");
        int quantity = Console.ReadLine();
        int subtotal = quantity * 2.5;
        Console.WriteLine("Your total cost for your apple(s) before taxes are $" + subtotal);
        int tax = 1.13;
        int finalcost = subtotal * tax;
        int onlytax = finaltotal - subtotal;
        Console.WriteLine("Tax: " + onlytax);
        Console.WriteLine("Your final total including tax is: " + finalcost);
        Console.Readkey();
    }
}
