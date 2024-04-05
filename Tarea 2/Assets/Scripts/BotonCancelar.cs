using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCancelar : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Cube;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(false);
            Cube.SetActive(false);
        }
    }
}