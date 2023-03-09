using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public float blinkSpeed = 5f;
    public Color visibleColor;
    public Color invisibleColor;

    void Update()
    {
        // Calculer la couleur intermédiaire à l'aide de la fonction Lerp
        Color color = Color.Lerp(invisibleColor, visibleColor, Mathf.PingPong(Time.time * blinkSpeed, 1));

        // Appliquer la couleur au texte
        myText.color = color;
    }
}

