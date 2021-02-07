using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_s1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject traffic;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(-9, 0.25f);
        transform.Rotate(0, 0, -90);

        traffic = GameObject.Find("TrafficManager");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (traffic.GetComponent<TrafficManager>().keeprun13)
        {
            rb.velocity = new Vector2(2.0f, 0);
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
    }

}

  
