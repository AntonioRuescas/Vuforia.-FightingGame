using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; //Importamos la librería de Vuforia

public class AttackPlayer : MonoBehaviour, IVirtualButtonEventHandler
{
    //Creamos las variables a utilizar
    public VirtualButtonBehaviour attackButton;
    public Animator animatorPlayer;
    public HealthScrip currentHealth;
       
    // Start is called before the first frame update
    void Start()
    {
        //Asignamos al scrip al botón de ataque al inicio de la ejecución 
        attackButton.RegisterEventHandler(this);
    }
    //Método para si el botón está pulsado que el player ejecute la acción de atacar, si la vida del enemigo llega a 0 no se ejecuta la función
    public void OnButtonPressed(VirtualButtonBehaviour attackButton)
    {
        if (currentHealth.health > 0) 
        { 
            Debug.Log("Botón presionado" + attackButton.VirtualButtonName);
            this.animatorPlayer.SetTrigger("Attack");
        }        
    }
    //Con este método cuando se colisiona con el enemigo le restamos salud    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<HealthScrip>().DamageHealth(0.1f);       
        }
    }
    //Método para decirnos cuando no estamos pulsando el botón
    public void OnButtonReleased(VirtualButtonBehaviour attackButton)
    {
        Debug.Log("Botón soltado");
    }
}
