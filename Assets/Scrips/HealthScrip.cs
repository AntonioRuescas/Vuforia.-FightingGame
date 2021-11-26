using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //Importamos librería para usar el manejo de escenas en Unity

public class HealthScrip : MonoBehaviour
{
    //Introducimos las variables a utilizar
    public float health;
    public Animator anim;
    public Image image;
    public GameObject character;
    private bool isDead = false;
   
    //Método para calcular el daño, si la variable isDead es verdadera se realiza el daño que se aplica en la barra de salud de los personajes, cuando llega a 0 se ejecutan el resto de métodos
    public void DamageHealth (float damage) {
        if (isDead) 
        {
            return;
        }
        health -= damage;
        image.fillAmount = health;
        if (health <= 0) 
        {
            this.anim.SetTrigger("Dead");
            isDead = true;
            StartCoroutine(RemoveEnemy());
            WinPlayer();  
        }
    }
    //Método para quitar al personaje que ha perdido el combate de la escena y cambiar la escena a victoria o derrota
    IEnumerator RemoveEnemy() {
        
        yield return new WaitForSeconds(4);
        character.SetActive(false);
        if (character.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("YouWin");
        }
        else {
            SceneManager.LoadScene("YouLose");
        }      
    }
    //Metodo para activar animaciones e los personajes si ganan
    void WinPlayer() {
        GameObject character = this.gameObject;
        if (character.CompareTag("Enemy"))
        {
            Animator player = GameObject.Find("Player").GetComponent<Animator>();
            player.SetTrigger("Win");
        }
        else { 
            Animator enemy = GameObject.Find("Enemy").GetComponent<Animator>();
            enemy.SetTrigger("Win");
        }      
    }
    
}
