using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroDePrueba : MonoBehaviour
{
    public string codAnimal;
    public int dias;
    int totalG;
    int totalM;
    // Start is called before the first frame update
    void Start()
    {
        if (dias >= 3)
        {
            if (codAnimal == "G")
            {
                totalG = 300 * dias;
                Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
                totalM = totalG / 100 * 80;
                Debug.Log("$" + totalM);

            }
            else if (codAnimal == "PP")
            {
                totalG = 400 * dias;
                Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
                totalM = totalG / 100 * 80;
                Debug.Log("$" + totalM);

            }
            else if (codAnimal == "PG")
            {
                totalG = 700 * dias;
                Debug.Log("Para ese período se necesitan  " + totalG + " gramos de alimento");
                totalM = totalG / 100 * 80;
                Debug.Log("$" + totalM);

            }
            else
            {
                Debug.Log("ERROR: inserte un codigo valido");
            }
        } else 
        {
            Debug.Log("ERROR: la estadia minima es de 3 dias");
        }



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
