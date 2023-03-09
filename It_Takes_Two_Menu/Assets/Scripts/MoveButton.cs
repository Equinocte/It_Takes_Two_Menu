using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button myButton;
    public float moveAmount = 10f; // Distance de d�placement
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = myButton.transform.position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // D�placer le bouton vers le haut
        myButton.transform.position += new Vector3(0f, moveAmount, 0f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Replacer le bouton � sa position d'origine
        myButton.transform.position = originalPosition;
    }
}
