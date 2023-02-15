using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _asteroidPrefab;
    [SerializeField]
    //public float _asteroidsSpeed = 5f;
    //[SerializeField]
    public float _asteroidsDelay = 1.5f; // задержка
    [SerializeField]
    public float _enemyDelay = 4f;
    public float RandX;
    Vector2 whereToSpawn; // где спавнить
    public float nextSpawn;

    void Start()
    {
        StartCoroutine(SpawnAsteroids());

        
    }

    public IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            yield return new WaitForSeconds(_asteroidsDelay); // начальная задержка

            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + _asteroidsDelay;

                RandX = Random.Range(-9.11f, 9.11f);

                whereToSpawn = new Vector2(RandX, transform.position.y);

                Instantiate(_asteroidPrefab, whereToSpawn, Quaternion.identity);
            }
        }
    }

    
}

