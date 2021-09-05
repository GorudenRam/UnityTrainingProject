using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float deley;
    public float progression;
    public EnemyData[] EnemysData;
    public GameObject enemyPrefab;

    public Rigidbody2D heroRb;


    void Start()
    {
        StartCoroutine(StartSpawn(deley, progression));
    }

    IEnumerator StartSpawn(float spawnDeley, float spawnProgression)
    {
        float x;
        float y;
        while (true)
        {
            yield return new WaitForSeconds(spawnDeley);
            if (Random.Range(0, 2) == 1)
            {
                x = Random.Range(-40, 40);
                if (Random.Range(0, 2) == 1)
                    y = 40;
                else
                    y = -40;
            }
            else
            {
                y = Random.Range(-40, 40);
                if (Random.Range(0, 2) == 1)
                    x = 40;
                else
                    x = -40;
            }
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
            enemy.GetComponent<EnemyMovement>().data = EnemysData[Random.Range(0, 2)];
            enemy.GetComponent<EnemyMovement>().heroRb = heroRb;
            spawnDeley *= spawnProgression;
        }
    }
}
