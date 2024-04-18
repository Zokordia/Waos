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

    public void RecibirDa�o(float da�o)
    {
        Vida -= da�o;
    }

    void ActualizarInterfaz()
    {
        Barra_Vida.fillAmount = Vida / VidaMax;
    }
}
