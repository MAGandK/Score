using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet; //Снаряд
    [SerializeField]
    private Transform _firePoint; //Точка, с которой будут отправляться снаряды
    [SerializeField]
    private float _stopSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(instObj());
    }

    private void ShootBullet() // стрелять снарядом
    {
        Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
    }

    IEnumerator instObj()
    {
        while (true)
        {
            ShootBullet();

            yield return new WaitForSeconds(_stopSpeed);
        }
    }
}



