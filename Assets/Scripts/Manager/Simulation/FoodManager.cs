using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    [SerializeField]
    private FoodManagerData data;

    private float timer = 0f;


    // Start is called before the first frame update
    private void Start()
    {
        // load food data
        List<FoodManagerData> possibilities = Resources.LoadAll<FoodManagerData>("Data/FoodManagerSO").ToList();

        data = possibilities[Random.Range(0, possibilities.Count())];
        for(int i = 0; i < data.startingFoodCount; i++)
        {
            Instantiate(data.foodPrefab, GetRandomPosition(), Quaternion.identity);
        }
        timer = data.spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Instantiate(data.foodPrefab, GetRandomPosition(), Quaternion.identity);
            timer = data.spawnInterval;
        }
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-8, 8f), 0.5f, Random.Range(-8, 8f));
    }
}
