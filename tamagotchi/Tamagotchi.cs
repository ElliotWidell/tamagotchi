using System;
using System.Collections.Generic;


public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private bool Alive = true;
    public string name = "";
    private int needToPoop = 0;
    public string playerInput = "";

    private List<string> words = new List<string>() { 
         "GonGongGingGang", "YoYoYo", "Just Woke Up, SWAG Is On"
         };

    private Random generator = new Random();


    public void feed()
    {
        if (hunger > 2)
        {
            hunger = hunger - 2;

        }
        else
        {
            Console.WriteLine("Not Hungry");
        }
        tick();


    }

    public void hi()
    {
        int randomWordNumb = generator.Next(0, words.Count);
        Console.WriteLine(words[randomWordNumb]);
        tick();

    }


    public void learnWord()
    {

        words.Add(Console.ReadLine());
        tick();



    }

   


    public void printStats()
    {

        Console.WriteLine($"Alive: {Alive}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Need To Poop: {needToPoop}");
    }

    public void tick()
    {

        boredom++;
        hunger++;
        needToPoop++;

        
    }

    public bool getAlive()
    {

        return Alive;


    }



    public void actions()
    {
    if(playerInput == "feed")
    {
        feed();

    }

    if(playerInput == "learn")
    {
        Console.WriteLine($"What Word Do You Want {name} To Learn?");
        learnWord();
        


    }
    if(playerInput == "speak")
    {

        hi();
    }

    if(playerInput == "rest")
    {

        needToPoop = needToPoop-2;
    }
    if(playerInput == "print")
    {

        printStats();
    }

    }



}

