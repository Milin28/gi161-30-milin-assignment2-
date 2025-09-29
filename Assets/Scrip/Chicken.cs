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
        int laid = 0;
        if (Happiness <= 50) laid = 0;
        else if (Happiness <= 79) laid = 2;
        else laid = 3;

        Eggs += laid;
        return $"{Name} produced {laid} eggs. Total eggs: {Eggs} eggs.";

        
    }


}
