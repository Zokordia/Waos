using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour
{
    BarraVida Da�oGenerado;
    public int cantidad;
    public float Da�oTiempo;
    float currentDa�oTiempo;
    void Start()
    {
        Da�oGenerado=GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDa�oTiempo += Time.deltaTime;
            if(currentDa�oTiempo > Da�oTiempo)
            {
                Da�oGenerado.Vida += cantidad; currentDa�oTiempo = 0.0f;
            }
        }
    }
}
