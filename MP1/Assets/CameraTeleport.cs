using UnityEngine;

public class CameraTeleport : MonoBehaviour
{
    public Transform xrOrigin;
    public Transform destination;

    public void Teleport()
    {
        xrOrigin.position = destination.position;
        xrOrigin.rotation = destination.rotation;
    }
}