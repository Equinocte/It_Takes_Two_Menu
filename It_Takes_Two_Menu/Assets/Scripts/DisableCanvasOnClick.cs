using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class DisableCanvasOnClick : MonoBehaviour
{
    public float delayTime = 2f; // Délai de 2 secondes avant de désactiver le Canvas
    public GameObject gameobj; // Référence au Canvas à désactiver
    public GameObject cam;
    public Animator animfin;



    private void Update()
    {
        // Vérifier si le bouton de la souris a été cliqué
        if (Input.GetMouseButtonDown(0))
        {
            // Démarrer une coroutine pour désactiver le Canvas après un délai
            StartCoroutine(DisableCanvas());
            animfin.SetBool("fin", true);
        }
    }

    private IEnumerator DisableCanvas()
    {
        // Attendre le délai spécifié
        yield return new WaitForSeconds(delayTime);

        // Désactiver le Canvas
        gameobj.SetActive(false);
        cam.SetActive(false);
        Debug.Log("Canvas fermé");

    }
}
