using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public float Vida = 150;
    public float VidaMax = 150;
    public GameObject PanelVida;
    public Image Barra_Vida;
    public GameObject PanelMuerte;
    void Update()
    {
        ActualizarInterfaz();
    }

    public void RecibirDaño(int daño)
    {
        Vida -= daño;

        if(Vida <= 0)
        {
            PanelMuerte.SetActive(true);
            Destroy(PanelVida);
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
    }

    void ActualizarInterfaz()
    {
        Barra_Vida.fillAmount = Vida / VidaMax;
    }
}
