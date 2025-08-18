using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 moveDirection = Vector3.forward;

    public float rotationSpeed = 45f;
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
