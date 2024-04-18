using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public float Vida = 150;
    public float VidaMax = 150;
    public Image Barra_Vida;
    void Update()
    {
        ActualizarInterfaz();
    }

    public void RecibirDaño(float daño)
    {
        Vida -= daño;
    }

    void ActualizarInterfaz()
    {
        Barra_Vida.fillAmount = Vida / VidaMax;
    }
}
