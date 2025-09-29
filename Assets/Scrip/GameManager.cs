
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
        /*animals[0].Feed("Corn", 3);
        animals[0].Sleep();
        animals[0].ShowStatus();

        //cow
        animals[1].Feed("Hay", 5); 
        animals[1].Moo();
        animals[1].ShowStatus();

        //cat
        animals[2].Feed("Fish", 5); 
        animals[2].MakeSound();
        animals[2].ShowStatus();*/

    }
}
