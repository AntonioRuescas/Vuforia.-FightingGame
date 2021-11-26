using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Variables a utilizar
    public float damage = 0.05f;
    public float radius = 30f;
    public LayerMask layerMask;
    
    // Update is called once per frame
    void Update()
    {
        //Cuando impactamos en el player con el scrip asignado a la mano del enemigo hacemos daño, solo se acciona el punto de daño en un momento de la animación
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layerMask);
        if (hits.Length > 0) 
        {
            hits[0].gameObject.GetComponent<HealthScrip>().DamageHealth(damage);            
        }
    }
}
