using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   // == set this up to publish an event to the system
   // == when killed

   // == public fields == 
   public int scoreValue {get {return scoreValue; } }
   // delegate type to use for event
    public delegate void EnemyKilled(Enemy enemy);

    //create static method to be implemented in the listener
    public static EnemyKilled EnemyKilledEvent;

   
    //== private fields == 
    [SerializeField] private int scoreValue = 10;

    //private method
    private void OnTriggerEnter2D(Collider whatHitMe);

}
