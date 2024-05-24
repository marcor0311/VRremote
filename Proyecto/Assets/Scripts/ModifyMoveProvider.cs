using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ModifyMoveProvider : MonoBehaviour
{
    [SerializeField] private GameObject moveProviderObject;
    [SerializeField] private float desiredSpeed = 2f;

    private ActionBasedContinuousMoveProvider moveProvider;
    private float initialMoveSpeed;

    private void Start()
    {
        if (moveProviderObject != null)
        {
            moveProvider = moveProviderObject.GetComponent<ActionBasedContinuousMoveProvider>();
            if (moveProvider == null)
            {
                Debug.LogError("El GameObject asignado no contiene un ActionBasedContinuousMoveProvider.");
                enabled = false;
            }
            else
            {
                initialMoveSpeed = moveProvider.moveSpeed;
            }
        }
        else
        {
            Debug.LogError("No se ha asignado un GameObject con el ActionBasedContinuousMoveProvider.");
            enabled = false;
        }
    }

    private void Update()
    {
        if (moveProvider != null)
        {
            // Modificar la velocidad mientras se mantiene presionado el botón de espacio
            if (Gamepad.current != null && Gamepad.current.leftStickButton.isPressed)
            {
                ChangeSpeed(desiredSpeed);
            }
            else
            {
                ResetSpeed();
            }
        }
    }

    // Cambiar la velocidad a una nueva velocidad
    public void ChangeSpeed(float newSpeed)
    {
        if (moveProvider != null)
        {
            moveProvider.moveSpeed = newSpeed;
        }
    }

    // Multiplicar la velocidad actual por un multiplicador
    public void MultiplySpeed(float multiplier)
    {
        if (moveProvider != null)
        {
            moveProvider.moveSpeed *= multiplier;
        }
    }

    // Restablecer la velocidad a la velocidad inicial
    public void ResetSpeed()
    {
        if (moveProvider != null)
        {
            moveProvider.moveSpeed = initialMoveSpeed;
        }
    }
}
