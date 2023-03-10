using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public string link;

    public void OpenWebsite()
    {
        Application.OpenURL(link);
    }
}
