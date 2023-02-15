using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Ship //враг
{
    [SerializeField]
    public float _enemySpeed = 3f;

    public GameObject _enemyPrefab;

    public float _enemyDelay = 4f;

    void Start()
    {
        EnemyMove();

        StartCoroutine(SpawnEnemy());
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            player.TakeDamage(_damageShip);
        }
    }

    public override void Die( )
    {
        Destroy(gameObject);

        Score.IncrementCount();
    }

    public void EnemyMove()
    {
        transform.Translate(Vector2.down * _enemySpeed * Time.deltaTime);
    }

    public IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(_enemyDelay);

        var enemy = Instantiate(_enemyPrefab, _enemyPrefab.transform.position, Quaternion.identity);

        while (true)
        {
            enemy.transform.Translate(Vector2.down * _enemySpeed * Time.deltaTime);

            yield return null;
        }
    }
}
