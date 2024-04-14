using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirMenu : MonoBehaviour
{
    public GameObject Panel;

    public void AbrirPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
