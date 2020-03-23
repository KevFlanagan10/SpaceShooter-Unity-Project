using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //== Private Fields ==
    private int playerScore = 0;


    //== Private Methods ==
    private void OnEnable()
    {
        Enemy.EnemyKilledEvent += OnEnemyKilledEvent;
    }
    private void OnDisable()
    {
        Enemy.EnemyKilledEvent -= OnEnemyKilledEvent;
    }

    private void OnEnemyKilledEvent(Enemy enemy)
    {
        //add the score value for the enemy to the players score
        playerScore += enemy.scoreValue;
        UpdateScore;
    }
    private void UpdateScore()
    {
        Debug.Log("Score: " + playerScore);
    } 
}
