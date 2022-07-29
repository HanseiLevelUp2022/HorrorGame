using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform destination;

    private void Update()
    {
        navMeshAgent.SetDestination(destination.position);
    }
}
