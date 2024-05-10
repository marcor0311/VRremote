using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarVelocidad : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider moveProvider;

    public void cambioVelocidad1()
    {
        moveProvider.moveSpeed = 1;
    }

    public void cambioVelocidad2()
    {
        moveProvider.moveSpeed = 10;
    }

    public void cambioVelocidad3()
    {
        moveProvider.moveSpeed = 50;
    }
}
