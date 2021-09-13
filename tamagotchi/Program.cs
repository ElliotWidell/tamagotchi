using System;

class Program
{
    static void Main(string[] args)
    {

        Tamagotchi tama = new Tamagotchi();
        Console.WriteLine(":)");
        tama.Hi();
        tama.printStats();
        tama.learnWord();
        Console.ReadLine();


    }
}