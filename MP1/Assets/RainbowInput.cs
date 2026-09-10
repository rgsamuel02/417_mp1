using UnityEngine;
using UnityEngine.InputSystem;

public class RainbowInput : MonoBehaviour
{
    public InputActionReference rainbowAction;
    public RainbowLighting rainbowLighting;

    void Start()
    {
        rainbowAction.action.Enable();
        rainbowAction.action.performed += OnRainbow;
    }

    void OnRainbow(InputAction.CallbackContext context)
    {
        rainbowLighting.ToggleLight();
    }

    void OnDestroy()
    {
        rainbowAction.action.performed -= OnRainbow;
    }
}