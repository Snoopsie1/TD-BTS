using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform Tower;
      Health health;
      Bullet bullet;
      private float aggroRange = 150f; 
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }
   

    // Update is called once per frame
    void Update()
    {
            if(Vector3.Distance(transform.position,Tower.position)< aggroRange)
            {
                navMeshAgent.SetDestination(Tower.position);
            }
        
    }
}
