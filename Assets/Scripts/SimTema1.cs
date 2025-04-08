using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimTema1 : MonoBehaviour
{
    public int dineroInicial;
    public string divisa;
    int dineroFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (dineroInicial >= 1000)
        {
            if (divisa == "D")
            {
                dineroFinal = dineroInicial / 1000;
                Debug.Log("El valor de " + dineroInicial + " pesos en dolares es " + dineroFinal);
            }
            else if (divisa == "R")
            {
                dineroFinal = dineroInicial / 500;
                Debug.Log("El valor de " + dineroInicial + " pesos en reales es " + dineroFinal);
            }
            else if (divisa == "E")
            {
                dineroFinal = dineroInicial / 1174;
                Debug.Log("El valor de " + dineroInicial + " pesos en euro es " + dineroFinal);
            }
            else
            {
                Debug.Log("Divisa seleccionada no valida");
            }
        }
        else
        {
            Debug.Log("El monto minimo es de 1000");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
