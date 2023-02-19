using System;
class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of antennas that were sighted. ");
        String numofantennas = Console.ReadLine();
        int numofantennasF;
        int.TryParse(numofantennas, out numofantennasF);
        Console.WriteLine("Enter the number of eyes that were sighted. ");
        String numofeyes = Console.ReadLine();
        int numofeyesF;
        int.TryParse(numofeyes, out numofeyesF);
        if (numofeyesF > 3 && numofeyesF < 6)
        {

        }

        Console.ReadKey();
    }
}
