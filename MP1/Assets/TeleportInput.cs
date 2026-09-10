using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportInput : MonoBehaviour
{
    public InputActionReference teleportAction;
    public CameraTeleport teleport;

    void Start()
    {
        teleportAction.action.Enable();
        teleportAction.action.performed += OnTeleport;
    }

    void OnTeleport(InputAction.CallbackContext context)
    {
        teleport.Teleport();
    }

    void OnDestroy()
    {
        teleportAction.action.performed -= OnTeleport;
    }
}