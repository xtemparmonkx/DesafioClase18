using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    protected EnemyData enemyData;
    public Transform Player;
    //public float Distance;
    //public float SpeedRotation;
    //public float stopDistance;
    public UnityEngine.AI.NavMeshAgent Enemy;
    public static event Action Follow;       
    
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, Player.transform.position) < enemyData.Distance)
        {
            Attack();
        }

        float dist = Vector3.Distance(transform.position, Player.transform.position);
        if(dist < enemyData.stopDistance)
        {
            StopEnemy();
        }        

    }

    
    private void OnEnable()
    {
        FloorTrigger.FloorTriggered += Attack; 
    }

    private void Attack()
    {
        Enemy.isStopped = false;
        Enemy.SetDestination(Player.transform.position);
        Debug.Log("attack");
    }
    private void StopEnemy()
    {
        Enemy.isStopped = true;
    }

}