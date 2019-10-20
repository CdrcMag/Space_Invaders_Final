using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis_Movement : MonoBehaviour
{
    public Variables var;
    
    private float timer = 0f;
    public float sensEnnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        var = FindObjectOfType<Variables>();
         sensEnnemies = var.ennemySpeed *(-1);
    }

    // Update is called once per frame
    void Update()
    {
        if (var.isRunning == true)
        {
            transform.position = new Vector2(transform.position.x + sensEnnemies, transform.position.y);
            timer += Time.deltaTime;
            if (timer > var.fallTime)
            {
                timer = 0f;
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
                sensEnnemies = -sensEnnemies;
            }
        }
    }
}
