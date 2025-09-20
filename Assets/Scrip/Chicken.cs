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
    

    public override void MakeSound()
    {
        
        Debug.Log($"{Name} say Cluck Cluck!");
    }


    /*public override void ShowStatus()
    {
        base.ShowStatus();
        Console.WriteLine($"Chicken Eggs: {Eggs}");
    }*/

    public override void Sleep()
    {
        base.Sleep();
    }

}
