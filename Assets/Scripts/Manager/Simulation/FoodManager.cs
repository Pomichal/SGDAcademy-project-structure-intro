using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    [SerializeField]
    private GameObject foodPrefab;

    [SerializeField]
    private int startingFoodCount = 5;


    [SerializeField]
    private float spawnInterval = 2.0f;
    private float timer = 0f;


    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 0; i < startingFoodCount; i++)
        {
            Instantiate(foodPrefab, GetRandomPosition(), Quaternion.identity);
        }
        timer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Instantiate(foodPrefab, GetRandomPosition(), Quaternion.identity);
            timer = spawnInterval;
        }
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-8, 8f), 0.5f, Random.Range(-8, 8f));
    }
}
