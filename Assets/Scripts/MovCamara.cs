using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    private Vector2 angulo = new Vector2(90 * Mathf.Deg2Rad,0);

    public Transform follow;
    public float distance;
    private bool isActivated = true;
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        if (hor != 0)
        {
            angulo.x += hor * Mathf.Deg2Rad;
        }

        float ver = Input.GetAxis("Mouse Y");
        if (ver != 0)
        {
            angulo.y += ver * Mathf.Deg2Rad;
            angulo.y = Mathf.Clamp(angulo.y, -80 * Mathf.Deg2Rad, 14 * Mathf.Deg2Rad);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActivated = !isActivated;
        }
    }

    void LateUpdate()
    {
        if (isActivated)
        {
            Vector3 orbit = new Vector3(
        Mathf.Cos(angulo.x) * Mathf.Cos(angulo.y),
        -Mathf.Sin(angulo.y),
        -Mathf.Sin(angulo.x) * Mathf.Cos(angulo.y));
            transform.position = follow.position + orbit * distance;
            transform.rotation = Quaternion.LookRotation(follow.position - transform.position);
        }
    }
}
