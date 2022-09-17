using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform destination;

    private void Awake()
    {
        navMeshAgent.updateRotation = false;
    }
    
    private void Update()
    {
        navMeshAgent.SetDestination(destination.position);
        var forward = new Vector2(transform.position.z, transform.position.x);
        var steeringTarget = new Vector2(navMeshAgent.steeringTarget.z, navMeshAgent.steeringTarget.x);
    
        //방향을 구한 뒤, 역함수로 각을 구한다.
        var dir = steeringTarget - forward;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    
        //방향 적용
        transform.eulerAngles = Vector3.up * angle;
    }
}