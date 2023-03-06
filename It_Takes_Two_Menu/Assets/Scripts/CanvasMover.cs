using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMover : MonoBehaviour

{
    public GameObject gameobj; // Nom du GameObject � activer/d�sactiver
    //public float timerDuration = 5f;
    //public float timer;
    //public bool isTimerActive = false;

    // Fonction pour activer le GameObject
    public void ActivateGameObject()
    {

        gameobj.SetActive(true);

    }

    // Fonction pour d�sactiver le GameObject
    public void DeactivateGameObject()
    {

        gameobj.SetActive(false);

    }
}

