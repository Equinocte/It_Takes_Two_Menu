using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class AnimButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator anim;


    public void OnPointerEnter(PointerEventData eventData)
    {
        anim.SetBool("go", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        anim.SetBool("go", false);
    }
}
