using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Bullet : MonoBehaviour
{
    public Health health;
    private NavMeshAgent navMeshAgent;
    public Transform Baloon;
     public float damage =5f;
     private float aggroRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, Baloon.position)< aggroRange)
        {
     
            navMeshAgent.SetDestination(Baloon.position);
        }
    }
        
    

    void OnCollisionEnter(Collision collision) 
    {

        if(collision.gameObject.tag == "Baloon")
        {
            health.TakeDamag(damage);
        }

        // var colHealth = other.gameObject.GetComponent<Health>();
        // if (colHealth != null)
        // {
        //     colHealth.TakeDamag(damage);
        //     if(other.gameObject.tag==("Baloon"))
        //     {
        //         gameObject.SetActive(true);

        //     }else
        //         {
        //             gameObject.SetActive(false);
        //         }
        // }
       
    }
}
