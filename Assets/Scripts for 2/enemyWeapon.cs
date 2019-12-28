using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeapon : MonoBehaviour {
    public Transform enemyFirepoint;

    public GameObject enemyBulletPrefab;

    public float firerate = 1f;
    public float firecountdown = 0f;

    void Update()
    {
       if(firecountdown <= 0)
        {
            Shoot();
            firecountdown = 1f / firerate;
        }
        firecountdown -= Time.deltaTime;
    }
	
	void Shoot()
    {
        Instantiate(enemyBulletPrefab, enemyFirepoint.position, enemyFirepoint.rotation);
    }
}
