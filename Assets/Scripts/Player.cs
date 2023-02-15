using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 10; // скорость перемещения
    [SerializeField]
    private float _healthPlayer = 5;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector3 mouse = new Vector3(Input.GetAxis("Mouse X") * speed * Time.deltaTime, Input.GetAxis("Mouse Y") * speed * Time.deltaTime, 0);

        transform.Translate(mouse * speed);
    }

    public void TakeDamage(int damage)// получать урон
    {
        _healthPlayer -= damage;

        Debug.Log("Health player:" + _healthPlayer);

        if (_healthPlayer <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
