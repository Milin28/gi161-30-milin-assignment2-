using System;
using Unity.Mathematics;
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
    public int Hunger { get; private set; }
    
    public int Happiness { get; private set; }
    
    public FoodType PreferedFood { get;protected set; }

    public void Init(string newName)
    {
        Name = newName;
        Hunger = 50;
        Happiness = 50;

    }
    public void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, 100);
    }
    public void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, 0, 100); 
    }
    /*public virtual void MakeSound()
    {
        Debug.Log($"Animal sounds??");
    }*/
    
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
    public void Feed(int amount) // Feed แบบที่ 1
    {
       
        if (amount < 0) amount = 0;


        AdjustHunger(-amount);
        AdjustHappiness(amount / 2);



        Debug.Log($"{Name} was fed {amount} units of generic food. Current Happiness {Happiness}");
    }

    // Feed แบบที่ 2
    public  void Feed(FoodType foodType, int amount)

    {
        if (foodType == PreferedFood)
        {
            AdjustHunger(-amount); // ลดความหิว
            AdjustHappiness(+15); // เพิ่มความสุข
            
            Debug.Log($"{Name} was fed {amount} units of perferred food : {foodType},Happiness increased 15 units, Current Happiness: {Happiness}");
        }
        else if (foodType == FoodType.RottenFood)
        {
            AdjustHappiness(-20); // ลดความสุข

            Debug.Log($"{Name} was fed with {foodType} :RottenMeat.Unhappy! Happiness decreased 20 units,Current Hunger: {Happiness}");
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
