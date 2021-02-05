using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_s3 : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(8, 0.71f);
        transform.Rotate(0, 0, 90);


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-2, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }

}
   
