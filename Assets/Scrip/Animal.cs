using System;
using UnityEngine;

public abstract class Animal : MonoBehaviour
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
    public FoodType PreferedFood { get;protected set; }

    public void Init(string newName)
    {
        Name = newName;
        Hunger = 50;
        Happiness = 50;

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
    /*public virtual void MakeSound()
    {
        Debug.Log($"Animal sounds??");
    }*/
    //public abstract void MakeSound(Animal target);
    public abstract void MakeSound();
    public virtual void ShowStatus()
    {
        Debug.Log($"Animal name: {Name} | Animal Hunger: {Hunger} | Animal Happiness: {Happiness} | Prefered Food {PreferedFood} ");
    }


    /*public void Feed(int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of food.");
    }
    public void Feed(string foodType, int foodAmount)
    {
        AdjustHunger(foodAmount);
        Debug.Log($"{Name} has been fed with {foodAmount} units of {foodType} food.");
    }*/


    public abstract string Produce();
    public virtual void Feed(int amount) // Feed แบบที่ 1
    {
        Hunger -= amount;
        if (Hunger < 0) Hunger = 0;

        Happiness += amount / 2;
        

        Debug.Log($"{Name} was fed {amount} units of generic food. Current Happiness {Happiness}");
    }

    // Feed แบบที่ 2
    public virtual void Feed(FoodType foodType, int amount)
    {
        if (foodType == PreferedFood)
        {
            Hunger -= amount;
            if (Hunger < 0) Hunger = 0;

            Happiness += 15;

                Debug.Log($"{Name} was fed({foodType}), ปริมาณอาหาร {amount}, Happiness เพิ่มเป็น {Happiness}");
        }
        else if (foodType == FoodType.RottenFood)
        {
            // Hunger ไม่ลด
            Happiness -= 20;
            if (Happiness < 0) Happiness = 0;

            Debug.Log($"{Name} ได้รับอาหารเน่า รู้สึกไม่ดี Happiness ลดลงเป็น {Happiness}");
        }
        else
        {
            // อาหารที่ไม่ชอบ 
            Feed(amount); 
        }
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
