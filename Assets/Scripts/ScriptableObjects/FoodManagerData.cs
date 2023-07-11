using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="FoodData", menuName="Data/FoodData", order = 1)]
public class FoodManagerData : ScriptableObject
{
    public GameObject foodPrefab;
    public int startingFoodCount;
    public float spawnInterval;
}
