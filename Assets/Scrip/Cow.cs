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
    /*public override void ShowStatus()
    {
        base.ShowStatus();
        Console.WriteLine($"Cow Milk: {milk}");
    }*/
    public override void Moo()
    {
        base.Moo();
    }   
    
    


}
