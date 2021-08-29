using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject _enemy;
    public GameObject EnemyPrefab;

    void Start()
    {
    }


    void Update()
    {
        MakeEnemy();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void MakeEnemy()
    {
        if (GameObject.FindGameObjectWithTag("Zombie") == null)
        {
            _enemy = Instantiate(EnemyPrefab);
            _enemy.transform.position = new Vector3(-15.19176f, 0, -0.03657f);
            _enemy.transform.Rotate(0, 89.95f, 0);
        }
    }

}
