using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackCard : MonoBehaviour
{
    //Asignamos las variables
    public int ID;
    public TrackableBehaviour track;
    public bool beCheck;
    public ARController controller;
    
    // Update is called once per frame
    void Update()
    {
        //Si el estado es trakeable y no está siendo trackeada se indica que se está enfocando, si no no indica nada
        if (track.CurrentStatus == TrackableBehaviour.Status.TRACKED && beCheck == false)
        {
            Debug.Log("Me están enfocando");
            beCheck = true;
            controller.ChargeObject(ID);
        }
        else if (track.CurrentStatus == TrackableBehaviour.Status.NO_POSE && beCheck == true)
        {
            beCheck = false;
        }
    }
}
