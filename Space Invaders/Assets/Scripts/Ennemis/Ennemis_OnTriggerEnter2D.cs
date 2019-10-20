using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis_OnTriggerEnter2D : MonoBehaviour
{
    public Variables var;
    public App_Main app;

    public GameObject ParticlesZone;
    public ParticleSystem exp;
    public Score scoreScript;
    

    // Start is called before the first frame update
    void Start()
    {
        var = FindObjectOfType<Variables>();
        app = FindObjectOfType<App_Main>();
        exp = FindObjectOfType<ParticleSystem>();
        scoreScript = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBullet"))
        {
            app.PlayDeathSound();
            ParticleSystem boom = Instantiate(exp, transform.position, Quaternion.identity);
            Destroy(boom, 0.2f);
            scoreScript.score += 100;
            var.isShooting = true;
            var.ennemyCount--;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        
        
    }


}
