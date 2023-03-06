using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMover : MonoBehaviour

{
    public GameObject gameobj; // Nom du GameObject à activer/désactiver
    //public float timerDuration = 5f;
    //public float timer;
    //public bool isTimerActive = false;

    // Fonction pour activer le GameObject
    public void ActivateGameObject()
    {

        gameobj.SetActive(true);

    }

    // Fonction pour désactiver le GameObject
    public void DeactivateGameObject()
    {

        gameobj.SetActive(false);

    }
}

