using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator anim;
    private Vector3 lastPos;
    private Vector3 currentPos;
    private bool isActivated = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActivated = !isActivated;
        }

        if (isActivated )
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    agent.SetDestination(hit.point);
                }
            }
            AnimationPlayer();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            agent.speed = 5;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            agent.speed = 1;
        }
    }

    private void AnimationPlayer()
    {
        currentPos=transform.position;
        if(currentPos.x != lastPos.x)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        lastPos = currentPos;
    }
}
