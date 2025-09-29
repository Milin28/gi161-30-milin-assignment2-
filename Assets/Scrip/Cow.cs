using System;
using UnityEngine;

public class Cow : Animal 
{


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
    
    /// methoods
    public override void MakeSound()
    {
      
        Debug.Log($"{Name} say Moo!");
    }
    
    public override void Moo()
    {
        base.Moo();
    }
    public Cow()
    {
        PreferedFood = FoodType.Hay;
    }
    public override string Produce()

    {
        
        Debug.Log($"{Name} produced {milk} liters of milk.");
        if (Happiness < 70)
        {
            return $"{Name} cannot produce milk because Happiness is too low.";
        }
        else
        {
          
            int milkProduced = Happiness / 10;
            return $"Total Milk: {milkProduced} units";
        }


    }



}
