using UnityEngine;

public class followplayer : MonoBehaviour
{

    public Transform player;

    private void Update()
    {
        if (player&&player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}