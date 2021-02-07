using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    public GameObject[] Red_s13;
    public GameObject[] Yellow_s13;
    public GameObject[] Green_s13;
    public GameObject[] Red_s24;
    public GameObject[] Yellow_s24;
    public GameObject[] Green_s24;

    public bool keeprun13;
    public bool keeprun24;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(controller());

    }

    void RedLights13_Greenlights24()
    {
        //Traffic s1 and s3 (Red)
        Red_s13[0].SetActive(true);
        Red_s13[1].SetActive(true);
        Yellow_s13[0].SetActive(false);
        Yellow_s13[1].SetActive(false);
        Green_s13[0].SetActive(false);
        Green_s13[1].SetActive(false);

        //Traffic s2 and s4 (Green)
        Red_s24[0].SetActive(false);
        Red_s24[1].SetActive(false);
        Yellow_s24[0].SetActive(false);
        Yellow_s24[1].SetActive(false);
        Green_s24[0].SetActive(true);
        Green_s24[1].SetActive(true);

        keeprun13 = false;
        keeprun24 = true;

    }

    void GreenLights13_Redlights24()
    {
        //Traffic s1 and s3 (Green)
        Red_s13[0].SetActive(false);
        Red_s13[1].SetActive(false);
        Yellow_s13[0].SetActive(false);
        Yellow_s13[1].SetActive(false);
        Green_s13[0].SetActive(true);
        Green_s13[1].SetActive(true);

        //Traffic s2 and s4 (Red)
        Red_s24[0].SetActive(true);
        Red_s24[1].SetActive(true);
        Yellow_s24[0].SetActive(false);
        Yellow_s24[1].SetActive(false);
        Green_s24[0].SetActive(false);
        Green_s24[1].SetActive(false);

        keeprun13 = true;
        keeprun24 = false;
    }

    void YellowLights13_Redlights24()
    {
        //Traffic s1 and s3 (Yellow)
        Red_s13[0].SetActive(false);
        Red_s13[1].SetActive(false);
        Yellow_s13[0].SetActive(true);
        Yellow_s13[1].SetActive(true);
        Green_s13[0].SetActive(false);
        Green_s13[1].SetActive(false);

        //Traffic s2 and s4 (Red)
        Red_s24[0].SetActive(true);
        Red_s24[1].SetActive(true);
        Yellow_s24[0].SetActive(false);
        Yellow_s24[1].SetActive(false);
        Green_s24[0].SetActive(false);
        Green_s24[1].SetActive(false);
    }

    void RedLights13_Yellowlights24()
    {
        //Traffic s1 and s3 (Red)
        Red_s13[0].SetActive(true);
        Red_s13[1].SetActive(true);
        Yellow_s13[0].SetActive(false);
        Yellow_s13[1].SetActive(false);
        Green_s13[0].SetActive(false);
        Green_s13[1].SetActive(false);

        //Traffic s2 and s4 (Yellow)
        Red_s24[0].SetActive(false);
        Red_s24[1].SetActive(false);
        Yellow_s24[0].SetActive(true);
        Yellow_s24[1].SetActive(true);
        Green_s24[0].SetActive(false);
        Green_s24[1].SetActive(false);
    }

    IEnumerator controller()
    {
        while (true)
        {
            GreenLights13_Redlights24();
            yield return new WaitForSeconds(2);
            YellowLights13_Redlights24();
            yield return new WaitForSeconds(1);
            RedLights13_Greenlights24();
            yield return new WaitForSeconds(2);
            RedLights13_Yellowlights24();
            yield return new WaitForSeconds(1);
        }
    }
}