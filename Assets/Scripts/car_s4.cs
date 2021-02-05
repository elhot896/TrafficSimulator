using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_s4 : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(0.27f, -4.5f);


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 2.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }

}
