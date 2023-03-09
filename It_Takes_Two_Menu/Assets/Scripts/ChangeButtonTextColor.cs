using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ChangeButtonTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;
    public Color hoverColor;
    private Color originalColor;
    public GameObject Canvas;


    void Start()
    {
        // Stocker la couleur d'origine du texte du bouton
        originalColor = buttonText.color;
    }

    // Appelé lorsque la souris entre sur le bouton
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Changer la couleur du texte en utilisant la couleur de survol
        buttonText.color = hoverColor;
    }

    // Appelé lorsque la souris quitte le bouton
    public void OnPointerExit(PointerEventData eventData)
    {
        // Revenir à la couleur d'origine du texte
        buttonText.color = originalColor;
    }

}

