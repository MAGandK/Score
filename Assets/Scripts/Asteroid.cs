using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private GameObject _asteroids;
    [SerializeField]
    public float _speed = 5f;
    [SerializeField]
    public float _asteroidsDelay = 1.5f; // задержка

    void Start()
    {
        AsteroidsMove();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();

        if (player != null)
        {
            player.TakeDamage(1);

            Die();
        }
    }

    public void Die()
    {
        Destroy(_asteroids);
    }

    public GameType Type
    {
        get;
    }

    public void AsteroidsMove()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }

    public IEnumerator SpawnAsteroid()
    {
        yield return new WaitForSeconds(_asteroidsDelay);

        var asteroid = Instantiate(_asteroids, _asteroids.transform.position, Quaternion.identity);

        while (true)
        {
            asteroid.transform.Translate(Vector2.down * _speed * Time.deltaTime);

            yield return null;
        }
    }
}