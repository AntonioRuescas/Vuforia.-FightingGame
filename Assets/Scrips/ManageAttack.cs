using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAttack : MonoBehaviour
{
    //Definimos variables a utilizar
    public GameObject attackPoint;
    //Activa el punto de daño del enemigo en la animación
    public void TurnOnAttackPoint()
    { 
        attackPoint.SetActive(true);
    }
    //Desactiva el punto de daño del enemigo en la animación
    public void TurnOffAttackPoint() 
    {
        attackPoint.SetActive(false);
    }
}
