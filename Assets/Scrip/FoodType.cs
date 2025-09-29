using UnityEngine;

public enum FoodType
{
    Hay,
    Grain,
    Tuna,
    RottenFood,
    AnimalFood

}
public class Food : MonoBehaviour
{
    public FoodType foodType;
    public int nutritionValue;
    public void Init(FoodType type, int nutrition)
    {
        foodType = type;
        nutritionValue = nutrition;
    }
}
