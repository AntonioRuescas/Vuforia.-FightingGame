using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importamos librería para usar el manejo de escenas en Unity
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        //Cargamos la escena 1 (Game) al pulsar sobre el botón que contiene el evento asociado
        SceneManager.LoadScene(1);
    }
    public void Exit() 
    {
        //Cuando se instale la aplicacion en algún dispositivo al pulsar sobre el botón ésta se quitará
        Application.Quit();
    }
}
