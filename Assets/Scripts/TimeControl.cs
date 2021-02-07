using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public void Lento()
    {
        Time.timeScale = 0.5f;
    }

    public void Normal()
    {
        Time.timeScale = 1;
    }

    public void Rapido()
    {
        Time.timeScale = 6;
    }

}
