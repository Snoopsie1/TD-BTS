using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 _movement;
    private float _speed = 10F;

    private float attackTime = 0F;
    private float attackStartTime = 0F;
    public Transform attackLocation;
    public float attackRange = 0.4F;
    public LayerMask enemies;

    // Start is called before the first frame update
    void Start()
    {
        attackLocation = GetComponent<Transform>().Find("AttackLocation");
    }

    // Update is called once per frame
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.z = Input.GetAxisRaw("Vertical");
        _movement = _movement.normalized;
    }

    void FixedUpdate()
    {
        transform.Translate(_movement * _speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        if (attackTime <= 0)
        {
            Collider[] enemiesHit = Physics.OverlapSphere(attackLocation.position, attackRange, enemies);

            foreach (var enemy in enemiesHit)
            {
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(attackLocation.position, attackRange);
    }
}
