using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaEsc : MonoBehaviour
{
    public GameObject Panel;
    private bool isActivated = true;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActivated = !isActivated;
        }
        if(isActivated)
        {
            Time.timeScale = 1f;
            Panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Time.timeScale = 0f;
            Panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
