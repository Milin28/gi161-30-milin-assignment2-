using System;
using UnityEngine;

public class Chicken: MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Chicken"; }
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
    private int eggs;
    public int Eggs
    {
        get { return eggs; }  
        set
        {
            if (value >= 0) eggs = value;
            else eggs = 0;
        }
    }
    public Chicken(string newName, int newHunger, int newHappiness , int newEggs)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Eggs = newEggs;


    }
    /////methoods
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
        Console.WriteLine("Cluck Cluck!");
    }
    public void Feed(string food)
    {
        Console.WriteLine($"{Name} is eating {food}.");
        AdjustHunger(-10);  // Ŵ�������ŧ 10 ˹���
        AdjustHappiness(5); // �����آ���� 5 ˹���
    }

    public void GetStatus()
    {
        Console.WriteLine($"Chicken {Name} - Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
        AdjustHunger(5);   // �������������鹵͹�͹
        AdjustHappiness(10); // �����آ������鹵͹�͹
    }

}
