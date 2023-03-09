using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class DisableCanvasOnClick : MonoBehaviour
{
    public float delayTime = 2f; // D�lai de 2 secondes avant de d�sactiver le Canvas
    public GameObject gameobj; // R�f�rence au Canvas � d�sactiver
    public GameObject cam;
    public Animator animfin;



    private void Update()
    {
        // V�rifier si le bouton de la souris a �t� cliqu�
        if (Input.GetMouseButtonDown(0))
        {
            // D�marrer une coroutine pour d�sactiver le Canvas apr�s un d�lai
            StartCoroutine(DisableCanvas());
            animfin.SetBool("fin", true);
        }
    }

    private IEnumerator DisableCanvas()
    {
        // Attendre le d�lai sp�cifi�
        yield return new WaitForSeconds(delayTime);

        // D�sactiver le Canvas
        gameobj.SetActive(false);
        cam.SetActive(false);
        Debug.Log("Canvas ferm�");

    }
}
