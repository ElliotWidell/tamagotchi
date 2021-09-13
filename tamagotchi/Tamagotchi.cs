using System;
using System.Collections.Generic;


public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private bool Alive = true;
    public string name = "";
    private int needToPoop = 0;

    private List<string> words = new List<string>() { "HeHe", "GonGongGingGang", "YoYoYo" };

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
    }

    public void Hi()
    {
        int randomWordNumb = generator.Next(0, words.Count);
        Console.WriteLine(words[randomWordNumb]);

    }


    public void learnWord()
    {

        words.Add(Console.ReadLine());



    }

    public void tick()
    {



    }


    public void printStats()
    {

        Console.WriteLine("Alive: ", Alive);
        Console.WriteLine("Boredom: ", boredom);
        Console.WriteLine("Hunger: ", hunger);
        Console.WriteLine("Need To Poop: ", needToPoop);
    }


}