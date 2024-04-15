using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaEsc : MonoBehaviour
{
    public GameObject Panel;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            Panel.SetActive(true);
        }
    }
}
