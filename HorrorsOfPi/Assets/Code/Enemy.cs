using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public static float agentSpeed;

    private void Start()
    {
        agent.speed = agentSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("Dead");
        }
    }
}
