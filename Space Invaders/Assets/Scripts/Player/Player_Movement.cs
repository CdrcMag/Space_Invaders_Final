using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Variables var;
    private float horizontalmove = 0f;
    public float speed = 5f;

   

    // Update is called once per frame
    void Update()
    {
        if (var.isRunning == true)
        {
            horizontalmove = Input.GetAxisRaw("Horizontal");

        }
    }

    private void FixedUpdate()
    {
        float min = -6f;
        float max = 6f;

        transform.position = new Vector2(Mathf.Clamp(transform.position.x + horizontalmove * speed * Time.deltaTime, min, max), transform.position.y);
    }
    
}
