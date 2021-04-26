using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGame : MonoBehaviour
{
    public GameObject rose;

    private int numSpace;
    private int numK;
    private float time;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numSpace++;
            time = 0;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            numK++;
        }
    }
}