using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatChanger : MonoBehaviour
{
    public Material[] materials;
    private Renderer rend;
    public TMP_Dropdown dropdown;
    public int secondElementIndex; // L'indice du deuxième élément dans la liste des sous-mesh

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void ChangeMaterial()
    {
        int materialIndex = dropdown.value;
        Material[] currentMaterials = rend.materials;
        currentMaterials[secondElementIndex] = materials[materialIndex];
        rend.materials = currentMaterials;
    }
}
