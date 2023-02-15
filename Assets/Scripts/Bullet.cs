using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _body;

    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private int _damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();

        _body.velocity = transform.up * _speed;  // выстрел шаром

        Destroy(gameObject, _speed);
    }

    void OnTriggerEnter2D(Collider2D hitInfo) //Метод, который срабатывает при попадании
    {
        Ship health = hitInfo.GetComponent<Ship>();

        if (health)
        {
            health.Hit(_damage);
        }
    }
}


