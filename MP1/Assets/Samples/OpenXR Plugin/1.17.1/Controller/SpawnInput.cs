using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnInput : MonoBehaviour
{
    public InputActionReference spawnAction;
    public ObjectSpawner spawner;

    void Start()
    {
        spawnAction.action.Enable();
        spawnAction.action.performed += OnSpawn;
    }

    void OnSpawn(InputAction.CallbackContext context)
    {
        spawner.SpawnObject();
    }

    void OnDestroy()
    {
        spawnAction.action.performed -= OnSpawn;
    }
}