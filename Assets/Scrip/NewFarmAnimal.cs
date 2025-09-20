using System;
using UnityEngine;

public class NewFarmAnimal : Animal
{
    public override void MakeSound()
    {
        
        Debug.Log($"{Name} say meowwww");
    }
}
