using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{

    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
