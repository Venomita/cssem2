using System;
class Program4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the weight of the first bowl: ");
        String weightfirstbowl = Console.ReadLine();
        int weightfirstbowlFinal;
        int.TryParse(weightfirstbowl, out weightfirstbowlFinal);
        Console.WriteLine("Please enter the weight of the second bowl: ");
        String weightsecondbowl = Console.ReadLine();
        int weightsecondbowlFinal;
        int.TryParse(weightsecondbowl, out weightsecondbowlFinal);
        Console.WriteLine("Please enter the weight of the third bowl: ");
        String weightthirdbowl = Console.ReadLine();
        int weightthirdbowlFinal;
        int.TryParse(weightthirdbowl, out weightthirdbowlFinal);
        if (weightfirstbowlFinal > weightsecondbowlFinal)
        {
            if (weightthirdbowlFinal > weightsecondbowlFinal)
            {
                if (weightthirdbowlFinal > weightfirstbowlFinal)
                {
                    Console.WriteLine("line 24 Mommy's bowl of porridge weighs " + weightfirstbowlFinal);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("line 29 Mommy's bowl of porridge weighs " + weightthirdbowlFinal);
                    Console.ReadKey();
                }
            }
        }
        if (weightsecondbowlFinal > weightfirstbowlFinal)
        {
            if (weightthirdbowlFinal > weightfirstbowlFinal)
            {
                if (weightsecondbowlFinal > weightthirdbowlFinal)
                {
                    Console.WriteLine("line 40 Mommy's bowl of porridge weighs " + weightthirdbowlFinal);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("line 45 Mommy's bowl of porridge weighs " + weightsecondbowlFinal);
                    Console.ReadKey();
                }
            }
        }
        if (weightsecondbowlFinal > weightthirdbowlFinal){
            if (weightfirstbowlFinal > weightthirdbowlFinal){
                if (weightfirstbowlFinal > weightsecondbowlFinal){
                    Console.WriteLine("line 53 Mommy's bowl of porridge weighs " + weightsecondbowlFinal);
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine("line 56 Mommy's bowl of porridge weighs " + weightfirstbowlFinal);
                    Console.ReadKey();
                }
            }
        }
    }
}