using UnityEngine;


public class enemyBullet : MonoBehaviour {

    public float speed = 20f;

    public Rigidbody2D rb;

    public int damage = 40;

    void Start()
    {
        rb.velocity = transform.up * -speed; 
    }

   void OnTriggerEnter2D(Collider2D hitinfo)
    {
        playerhealth playerhealth = hitinfo.GetComponent<playerhealth>();

        if(playerhealth != null)
        {
            playerhealth.TakeDamage(damage);
            
        }
        if(hitinfo.tag == "Player")
        {
            Destroy(gameObject);
            
        }
    }
}
