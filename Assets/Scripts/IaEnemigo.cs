using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IaEnemigo : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;

    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);

        AnimationPlayer();
    }

    private void AnimationPlayer()
    {

        if (IA.velocity == Vector3.zero)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

    }
}
