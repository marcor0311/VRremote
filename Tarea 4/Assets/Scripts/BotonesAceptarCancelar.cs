using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesAceptarCancelar : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Cube;


    public void OpenPanel()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
            Cube.SetActive(true);
        }
    }
}
