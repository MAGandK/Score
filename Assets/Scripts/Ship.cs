using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public abstract class Ship : MonoBehaviour
{
    public int _hp = 5;

    public int _damageShip = 2;

    public void Hit(int damage) //удар противника, будет повреждение
    {
        _hp -= damage;

        if (_hp <= 0)
        {
            Die();
        }
    }

    public virtual void Die() // смерть 
    {
        Destroy(gameObject);
    }
}