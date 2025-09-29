using System;
using UnityEngine;

public class Chicken: Animal
{
    
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
    
    /////methoods
    

    
    
    public override void Sleep()
    {
        base.Sleep();
    }
    public override void MakeSound()
    {
        
        Debug.Log($"{Name} say Cluck Cluck!");
    }
    public Chicken()
    {
        PreferedFood = FoodType.Grain;
    }
    public override string Produce()

    {
        Debug.Log($"{Name} produced {eggs} eggs.");
        if (Happiness < 50)
        {
            return "Chicken cannot produce eggs because Happiness is too low.";
        }
        else if (Happiness >= 51 && Happiness <= 79)
        {
            return "Chicken produced 2 eggs.";
        }
        else
        {
            return "Chicken produced 3 eggs.";
        }
    }


}
