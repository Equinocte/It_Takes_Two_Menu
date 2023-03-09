using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button myButton;
    public float moveAmount = 10f; // Distance de déplacement
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = myButton.transform.position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Déplacer le bouton vers le haut
        myButton.transform.position += new Vector3(0f, moveAmount, 0f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Replacer le bouton à sa position d'origine
        myButton.transform.position = originalPosition;
    }
}
