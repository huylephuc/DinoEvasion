using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;

    void Update()
    {
        transform.position = car.position + offset;
    }
}
