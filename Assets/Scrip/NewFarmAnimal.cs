using System;
using UnityEngine;

public class NewFarmAnimal : Animal

{
    public int NewResource { get; private set; }
    
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
        int kit = 0;
        if (Happiness <= 50) kit = 0;
        else if (Happiness <= 79) kit = 4;
        else kit = 6;

        NewResource += kit;
        return $"{Name} produced {kit} kittens. Total Kittens: {NewResource} kittens.";

       
    }
}
