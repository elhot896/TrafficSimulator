﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_s4 : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool run = false;
    public GameObject traffic;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(0.27f, -4.5f);

        traffic = GameObject.Find("TrafficManager");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (traffic.GetComponent<TrafficManager>().keeprun24 || run)
        {
            rb.velocity = new Vector2(0, 2.0f);
        }
              
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Run")
        {
            run = true;
        }
    }

}
