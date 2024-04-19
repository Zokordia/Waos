using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    Puntuacion contador;
    void Start()
    {
        contador=GameObject.FindWithTag("Player").GetComponent<Puntuacion>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            contador.puntaje = contador.puntaje - 1;
            Destroy(gameObject);
        }
    }
}
