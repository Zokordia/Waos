using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMenu : MonoBehaviour
{
    public GameObject Panel;
    public void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 1f;

            Panel.SetActive(false);
        }
    }
}
