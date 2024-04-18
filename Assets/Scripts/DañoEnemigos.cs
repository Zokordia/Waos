using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigos : MonoBehaviour
{
    public float daño;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<BarraVida>())
        {
            other.GetComponent<BarraVida>().RecibirDaño(daño);
        }
    }
}
