using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour {

    int health = 100;

    public Text digit;

    public GameObject explosion;
    public float delay = 5f;

   public void TakeDamage(int damage)
    {
        health -= damage;
        digit.text = health.ToString();
        if(health == 0)
        {
            StartCoroutine(Die());
            SceneManager.LoadScene(2);
        }
        
    }

    IEnumerator Die()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        yield return new WaitForSeconds(5);
    }

    public void Update()
    {
        if (Input.GetKeyDown((KeyCode.Escape)))
        {
            SceneManager.LoadScene(0);
        }
    }
}
