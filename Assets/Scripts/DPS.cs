using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour
{
    BarraVida DaņoGenerado;
    public int cantidad;
    public float DaņoTiempo;
    float currentDaņoTiempo;
    void Start()
    {
        DaņoGenerado=GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDaņoTiempo += Time.deltaTime;
            if(currentDaņoTiempo > DaņoTiempo)
            {
                DaņoGenerado.Vida += cantidad; currentDaņoTiempo = 0.0f;
            }
        }
    }
}
