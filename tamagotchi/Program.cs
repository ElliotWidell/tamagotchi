using System;

class Program
{
    static void Main(string[] args)
    {

        Tamagotchi tama = new Tamagotchi();
        Console.WriteLine("Hello Please Name Your Tamagotchi: ");
        tama.name = Console.ReadLine();
        Console.WriteLine($"Great Your Tamagotchi Is Now Named {tama.name}");
        Console.WriteLine($"You Can Interact With {tama.name} By Typing: Feed, Learn, Speak, Rest Or Print");
        while(tama.getAlive())
        {
        tama.playerInput = Console.ReadLine().ToLower();
        tama.actions();
        

        
        
        



        }

        
        


    }
}