﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Variables var;

    // Start is called before the first frame update
    void Start()
    {
        var = FindObjectOfType<Variables>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        var.isShooting = true;
    }
    

}
