
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> animalsPrefabs; //หลายๆชนิด
    public Animal currentAnimal; //ตัวเดียว
    public List<Animal> animals = new List<Animal>();
    void Start()
    {
        Debug.Log($"Welcome to Oasis Farm");
        
        //chicken
        currentAnimal = Instantiate(animalsPrefabs[0]);
        currentAnimal.Init("Mori");
        animals.Add(currentAnimal);

        //cow
        currentAnimal = Instantiate(animalsPrefabs[1]);
        currentAnimal.Init("Boo");
        animals.Add(currentAnimal);

        //cat
        currentAnimal = Instantiate(animalsPrefabs[2]);
        currentAnimal.Init("Neko");
        animals.Add(currentAnimal);
        Debug.Log($"There are {animals.Count} animals living in the Oasis Farm ");
        //show status
        foreach (var animal in animals)
        {
            animal.ShowStatus();
            
        }
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed(5);
        }
        animals[0].Feed(10);// Feed แบบที่ 1

        animals[0].Feed(FoodType.Grain, 20); // Feed แบบที่ 2
        Debug.Log(animals[0].Produce());

        animals[0].Feed(FoodType.Grain, 30);
        Debug.Log(animals[0].Produce());

        animals[0].Feed(FoodType.Grain, 30);
        Debug.Log(animals[0].Produce());

        animals[0].Feed(FoodType.RottenFood, 10);
        Debug.Log(animals[0].Produce());

        animals[1].Feed(FoodType.RottenFood, 10);
        Debug.Log(animals[1].Produce());

        animals[1].Feed(FoodType.Hay, 10);
        Debug.Log(animals[1].Produce());

        animals[2].Feed(FoodType.Tuna, 30);
        Debug.Log(animals[2].Produce());

        animals[2].Feed(FoodType.RottenFood, 30);
        Debug.Log(animals[2].Produce());

        foreach (var animal in animals)
        {
            animal.ShowStatus();

        }




    }
}
