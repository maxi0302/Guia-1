using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimTema2 : MonoBehaviour
{
    public string nombreAlumno;
    public int year;
    public string especialidad;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "") {
            Debug.Log("Error: Nombre no valido");

        } else {
            if (year <= 0 || year > 5) {
                Debug.Log("Error: Año no valido");

            } else {
                if (year < 3) {
                    Debug.Log("Error: Aun sigues en ciclo basico");

                } else {
                    if (especialidad != "D" && especialidad != "T" && especialidad != "H" && especialidad != "M" && especialidad != "G") {
                        Debug.Log("Error: Solo se puede ingresar D, T, H, M, G");

                    } else {
                        Debug.Log("Muchas gracias " + nombreAlumno + "!");

                    }
                }

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
