using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_s2 : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(-0.33f, -36);
        transform.Rotate(0, 0, 180);


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -2.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
