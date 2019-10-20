using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooting : MonoBehaviour
{
    public float bulletSpeed = 10f;

    public GameObject bulletPrefab;
    public GameObject ShootZone;
    public Transform BulletContainer;
    private Rigidbody2D rb;
    public Variables var;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (var.isRunning == true)
        {
            if (var.isShooting == true)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var.isShooting = false;
            GameObject bullet = Instantiate(bulletPrefab, ShootZone.transform.position, Quaternion.identity, BulletContainer);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * bulletSpeed;
            Destroy(bullet, 3f);
        }
    }
}
