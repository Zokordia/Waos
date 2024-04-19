using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int puntaje = 8;
    public GameObject PanelGanar;
    public GameObject PanelVida;

    private void Update()
    {
        if (puntaje <= 0) 
        {
            PanelGanar.SetActive(true);
            Destroy(PanelVida);
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
    }

}
