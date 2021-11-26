using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARController : MonoBehaviour
{
    //Según el id asignado a cada carta, se muestra un mensaje por consola
    public void ChargeObject(int id) 
    {
        if (id == 1)
        {
            Debug.Log("Esperando enemigo");
        }
        else if (id == 2)
        {
            Debug.Log("Esperando jugador");          
        }
    }
}
