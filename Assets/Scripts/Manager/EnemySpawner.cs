using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    [SerializeField]
    private GameObject enemyPrefab;

    void Start()
    {
        Events.onGameStarted.AddListener(StartSpawning);
    }


    // Start is called before the first frame update
    public void StartSpawning()
    {
        for(int i=0; i<5; i++)
        {
            Instantiate(enemyPrefab, GetRandomPos(), Quaternion.identity);
        }
    }

    private Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(-3, 3f), 0, Random.Range(-3, 3f));
    }

}
