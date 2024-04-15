using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarMenu : MonoBehaviour
{
    public GameObject Panel;
    public void Reanudar() {
            Time.timeScale = 1f;

            Panel.SetActive(false);
        }
}
