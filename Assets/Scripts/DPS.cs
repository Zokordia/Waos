using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : MonoBehaviour
{
    BarraVida Vida;
    public int da�o;
    public float Dps;
    public float TiempoDa�o;

    public void Start()
    {
        Vida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            TiempoDa�o += Time.deltaTime;
            if (TiempoDa�o>Dps)
            {
                other.GetComponent<BarraVida>().RecibirDa�o(da�o);
                TiempoDa�o = 0.0f;
            }
        }
    }
}
