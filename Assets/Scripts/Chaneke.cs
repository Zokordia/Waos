using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaneke : MonoBehaviour
{
    PlayerNavMesh veloz;
    void Start()
    {
        veloz = GameObject.FindWithTag("Player").GetComponent<PlayerNavMesh>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            veloz.vel = veloz.vel + 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            veloz.vel = veloz.vel - 1;
        }
    }
}
