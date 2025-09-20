using System;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Animal"; }
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
    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;

    }
    public void AdjustHunger(int amount)
    {
        Hunger -= amount;
        if (Hunger < 0) Hunger = 0;
    }
    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
        if (Happiness < 0) Happiness = 0;
    }
    public virtual void MakeSound()
    {
        Debug.Log($"Animal sounds??");
    }
    public void Feed(int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of food.");
    }
    public void Feed(string foodType, int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of {foodType} food.");
    }
    public virtual void ShowStatus()
    {
        Debug.Log($"Animal name: {Name} | Animal Hunger: {Hunger} | Animal Happiness: {Happiness} ");
    }



    // ลองทำแล้วมันไม่ได้ เลยเอามาใส่ในนี้แทน
    public virtual void Moo()
    {
        Debug.Log($"{Name} gives a loud MooMooMoo| current Happiness: {Happiness}");
        AdjustHunger(5);
        AdjustHappiness(10);
    }
    public virtual void Sleep()
    {
        Debug.Log($"{Name} slept and feels alittle hungry, but very happy");
        AdjustHunger(5);   // ความหิวเพิ่มขึ้นตอนนอน
        AdjustHappiness(10); // ความสุขเพิ่มขึ้นตอนนอน
    }
}
