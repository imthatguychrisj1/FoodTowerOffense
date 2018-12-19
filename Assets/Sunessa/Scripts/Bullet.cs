using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    private float removeBullet = 1.0f;

    // Use this for initialization
    void Start() {
        rb.velocity = transform.right * speed;
    }
    void Update()
    {
        if (removeBullet > 0)
        {
            removeBullet -= Time.deltaTime;
        }
        if (removeBullet <=0)
        {
            Destroy(gameObject);
        }
    }
    void onTriggerenter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
