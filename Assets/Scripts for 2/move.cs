using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour {
    public Rigidbody2D rb;
    

    public float speed = 10f;

    public float movespeed = 5f;

	
	// Update is called once per frame
	void Update () {
		 if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.up * speed;
        }
       /* else if(Input.GetButtonDown("Mouse Y"))
        {
            rb.velocity = 
        }*/
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -movespeed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movespeed * Time.deltaTime;
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "arrow")
        {
            SceneManager.LoadScene(2);
        }
        if(col.tag == "flag")
        {
            SceneManager.LoadScene(3);
        }
        
    }

}
