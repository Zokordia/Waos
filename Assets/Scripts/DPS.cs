using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour
{
    BarraVida Vida;
    public int daño;
    public float Dps;
    public float TiempoDaño;

    public void Start()
    {
        Vida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TiempoDaño += Time.deltaTime;
            if (TiempoDaño>Dps)
            {
                other.GetComponent<BarraVida>().RecibirDaño(daño);
                TiempoDaño = 0.0f;
            }
        }
    }
}
