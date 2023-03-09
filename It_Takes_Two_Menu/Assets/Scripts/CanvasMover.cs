using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasMover : MonoBehaviour

{

    public TextMeshProUGUI buttonText;
    private Color originalColor;
    public Color hoverColor;
    public GameObject gameobj; // Nom du GameObject à activer/désactiver
    //public float timerDuration = 5f;
    //public float timer;
    //public bool isTimerActive = false;

    // Fonction pour activer le GameObject

    private void Start()
    {
        originalColor = buttonText.color;
    }
    public void ActivateGameObject()
    {

        gameobj.SetActive(true);

    }

    // Fonction pour désactiver le GameObject
    public void DeactivateGameObject()
    {

        gameobj.SetActive(false);

    }

    private void OnDisable()
    {
        buttonText.color = hoverColor;
    }
}

