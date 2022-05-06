using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [HideInInspector] public float bulletForce = 20f;

    public float bulletDamage = 10f;

    private void Start()
    {
        
        Destroy(gameObject, 2f);
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * bulletForce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy Attacked");
            EnemyAI enemy = other.gameObject.GetComponent<EnemyAI>();

           
            enemy.TakeDamage(bulletDamage);
          
        }
    }

}
