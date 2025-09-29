using System;
using UnityEngine;

public class NewFarmAnimal : Animal

{
    private int kittens;
    public int Kittens
    {
        get { return kittens; }
        set
        {
            if (value >= 0) kittens = value;
            else kittens = 0;
        }
    }
    public override void MakeSound()
    {
        
        Debug.Log($"{Name} say meowwww");
    }
    public NewFarmAnimal()
    {
        PreferedFood = FoodType.Tuna;
    }
    public override string Produce()

    {
        Debug.Log($"{Name} produced {kittens} kittens.");
        if (Happiness < 50)
        {
            return "Cat cannot produce kittens because Happiness is too low.";
        }
        else if (Happiness >= 51 && Happiness <= 79)
        {
            return "Cat produced 1 kitten.";
        }
        else
        {
            return "Cat produced 2 kittens.";
        }
    }
}
