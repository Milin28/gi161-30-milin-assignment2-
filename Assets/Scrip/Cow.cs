using System;
using UnityEngine;

public class Cow : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Cow"; }
            else name = value;
        }
    }
    private int hunger;
    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;
        }
    }

    private int happiness;
    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0) happiness = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }
    private float milk;
    public float Milk
    {
        get { return milk; }
        set
        {
            if (value >= 0) milk = value;
            else milk = 0;
        }
    }
    public Cow(string newName, int newHunger, int newHappiness, int newMilk)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = newMilk;


    }
    /// methoods
    public void AdjustHunger(int amount)
    {
        Hunger += amount;
        if (Hunger < 0) Hunger = 0;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        if (Happiness < 0) Happiness = 0;
    }

    public void MakeSound()
    {
        Console.WriteLine("Moo!");
    }

    public void Feed(string food)
    {
        Console.WriteLine($"{Name} is eating {food}.");
        AdjustHunger(-10);
        AdjustHappiness(5);
    }

    public void GetStatus()
    {
        Console.WriteLine($"Cow {Name} - Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk} liters");
    }

    public void Moo()
    {
        Console.WriteLine("Moo Moo!");
    }
}
