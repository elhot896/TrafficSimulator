using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car01;
    public GameObject[] car02;
    public GameObject[] car03;
    public GameObject[] car04;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CarSpawner_s1_s3", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CarSpawner_s1_s3()
    {
        Instantiate(car01[0], transform.position, Quaternion.identity);
        Instantiate(car02[0], transform.position, Quaternion.identity);

    }
}
