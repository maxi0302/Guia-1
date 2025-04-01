using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumUno : MonoBehaviour
{
    int Num1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Num1 += 2;
        Debug.Log(Num1);
        Num1 *= Num1;
        Debug.Log(Num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
