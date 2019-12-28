using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health = 100;

    public GameObject animator;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Instantiate(animator, transform.position, transform.rotation);
            Die();
        }
       
    } 

    void Die()
    {
        Destroy(gameObject);
    }
}
