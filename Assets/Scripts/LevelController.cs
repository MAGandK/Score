using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    private Spawner _spawner;

    private GameType Type;

    //void Start()
    //{
    //    StartCoroutine(PlayGame());
    //}

    //private IEnumerator PlayGame()
    //{
    //    while (true)
    //    {
    //         switch (Type)
    //        {
    //            case GameType.Asteroid:
    //                yield return StartCoroutine(_spawner.SpawnAsteroids());
    //                break;
    //            case GameType.Ship:
    //                yield return StartCoroutine(_spawner.SpawnEnemy());
    //                break;
    //            case GameType.AsteroidAndShip:
    //                yield return StartCoroutine(_spawner.SpawnAsteroids());
    //                yield return StartCoroutine(_spawner.SpawnEnemy());
    //                break;

    //            default:
    //                Debug.Log("Error!");
    //                break;
    //        }

    //        yield return null;
    //    }
    }
//}