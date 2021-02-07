using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car01;
    public GameObject[] car02;
    public GameObject[] car03;
    public GameObject[] car04;

    public GameObject spawning;


    // Start is called before the first frame update
    void Start()
    {
        spawning = GameObject.Find("TrafficManager");

        InvokeRepeating("CarSpawner_s1_s3", 1, 2);
        InvokeRepeating("CarSpawner_s2_s4", 1, 1);
        
    }

    void CarSpawner_s1_s3()
    {
        if(spawning.GetComponent<TrafficManager>().keeprun13)
        {
            //Car_s1 Spawner
            Instantiate(car01[0], transform.position, Quaternion.identity);
            //Car_s3 Spawner
            Instantiate(car03[0], transform.position, Quaternion.identity);
        }

    }

    void CarSpawner_s2_s4()
    {
        if (spawning.GetComponent<TrafficManager>().keeprun13)
        {
            //Car_s2 Spawner
            Instantiate(car02[0], transform.position, Quaternion.identity);
            //Car_s4 Spawner
            Instantiate(car04[0], transform.position, Quaternion.identity);
        }
        
    }
}
