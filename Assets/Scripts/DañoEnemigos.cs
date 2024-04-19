using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigos : MonoBehaviour
{
    BarraVida Vida;
    public int daño;

    public void Start()
    {
      Vida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<BarraVida>().RecibirDaño(daño);
        }
    }
}
