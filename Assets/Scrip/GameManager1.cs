using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            Chicken chicken = new Chicken("Dragon", 10, 10, 0);
            Cow cow = new Cow("Hydra", 10, 10, 0);
            Debug.Log("Welcome to ");
            Debug.Log($"{chicken} and {cow}");
            Debug.Log("=== Chicken ===");
            chicken.GetStatus();
            chicken.MakeSound();
            chicken.Feed("carrot");
            chicken.GetStatus();
            chicken.Sleep();


            Debug.Log("=== Cow ===");
            cow.GetStatus();
            cow.MakeSound();
            cow.Feed("grass");
            cow.GetStatus();
            cow.Moo();

            Debug.Log("Goodbye");
        
    }

    
}
