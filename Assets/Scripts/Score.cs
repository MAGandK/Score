using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static int _scoreCount = 0;

    [SerializeField]
    private TextMesh _scoreLabel;

    private static Score _instance;

    void Start()
    {
        _scoreLabel.text = "Score:" + _scoreCount;

        _instance = GetComponent<Score>();
    }

    public static void IncrementCount()
    {
        _scoreCount++;

        _instance._scoreLabel.text = "Score:" + _scoreCount;
    }
}
