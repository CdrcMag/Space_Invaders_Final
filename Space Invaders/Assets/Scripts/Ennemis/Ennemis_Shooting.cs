using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis_Shooting : MonoBehaviour
{
    public float shootTime = 0f;
    public float bulletSpeed = 10f;
    private float timer = 0f;

    public Variables var;
    private Rigidbody2D rbBullet;
    public GameObject bulletPrefab;
    public Transform BulletContainer;
    private Transform ShootZone;

    // Start is called before the first frame update
    void Start()
    {
        var = FindObjectOfType<Variables>();
        ShootZone = gameObject.GetComponentInChildren<Transform>();
        shootTime = Random.Range(2f, 10f);
        ShootZone = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (var.isRunning == true)
        {
            timer += Time.deltaTime;

            if (timer > shootTime)
            {
                timer = 0f;
                shootTime = Random.Range(2f, 20f);
                Shoot();
            }
        }
    }

    void Shoot()
    {
       
        GameObject bullet = Instantiate(bulletPrefab, ShootZone.transform.position, Quaternion.identity);
        rbBullet = bullet.GetComponent<Rigidbody2D>();
        rbBullet.velocity = -transform.up * bulletSpeed;
        Destroy(bullet, 3f);

    }
}
