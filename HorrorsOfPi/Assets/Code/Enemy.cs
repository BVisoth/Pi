using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float agentSpeed;

    private void Start()
    {
        agent.speed = agentSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
