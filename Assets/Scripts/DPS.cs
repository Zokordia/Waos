using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour
{
    BarraVida DañoGenerado;
    public int cantidad;
    public float DañoTiempo;
    float currentDañoTiempo;
    void Start()
    {
        DañoGenerado=GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDañoTiempo += Time.deltaTime;
            if(currentDañoTiempo > DañoTiempo)
            {
                DañoGenerado.Vida += cantidad; currentDañoTiempo = 0.0f;
            }
        }
    }
}
