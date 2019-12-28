using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firepoint;
    public int damage = 40;
    public LineRenderer lineRenderer;
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
	}
    IEnumerator Shoot()
    {
        //shooting logic
       RaycastHit2D hitinfo = Physics2D.Raycast(firepoint.position, firepoint.up);

        if (hitinfo)
        {
            Enemy enemy = hitinfo.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            lineRenderer.SetPosition(0, firepoint.position);
            lineRenderer.SetPosition(1, hitinfo.point);
        }
        else
        {
            lineRenderer.SetPosition(0, firepoint.position);
            lineRenderer.SetPosition(1, firepoint.position + firepoint.up * 100);
        }

        lineRenderer.enabled = true;

        yield return 0;
        lineRenderer.enabled = false;
    }
}
