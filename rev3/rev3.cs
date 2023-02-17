//Name: Hamza Paracha
//Assignment: Review 1 Program 2
//Date: February 10
//Description: using tryparse you convert the string entered into an int to calculate the age of the oldest son who has the same age difference as the middle and youngest son.
using System;
class Program2
{
    static void Main(string[] args)
    {
        //finding the ages of the middle and youngest children
        Console.WriteLine("Please enter the age of the youngest child: ");
        String yAge = Console.ReadLine();
        Console.WriteLine("Please enter the age of the middle child: ");
        String mAge = Console.ReadLine();
        //declare the values of the age after tryparse is done
        int yAgeFinal;
        int mAgeFinal;
        int.TryParse(yAge, out yAgeFinal);
        int.TryParse(mAge, out mAgeFinal);
        //finding the difference because it is an arethmatic sequence
        int diff = mAgeFinal - yAgeFinal;
        //finding the oldest childs age using the difference
        int oAgeFinal = mAgeFinal + diff;
        //printing it all out for the user
        Console.WriteLine("The youngest sons age is " + yAgeFinal);
        Console.WriteLine("The middle sons age is " + mAgeFinal);
        Console.WriteLine("The oldest sons age is " + oAgeFinal);
        Console.ReadKey();
    }
}

