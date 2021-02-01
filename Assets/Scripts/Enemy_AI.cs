using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    [SerializeField] private float EnemySpeed;
    public NavMeshAgent nav;
    [SerializeField] GameObject Player;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        nav = GetComponent<NavMeshAgent>();
        nav.speed = EnemySpeed;
    }

    void Update()
    {
        if(Player != null)
        {
            nav.isStopped = false;
            nav.SetDestination(Player.transform.position);
        }
        else
        {
            nav.isStopped = true;
        }
    }
}
