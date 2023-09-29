using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        // Selecciono un enemigo al azar para que aparezca al inicio del juego
        var rand = Random.Range(0, enemies.Length);

        Instantiate(enemies[rand], transform.position, Quaternion.identity);
    }
}
