using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Transform door; 
    private bool isOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            door.Rotate(0, 90, 0); // Y轴旋转90度，模拟开门
            isOpen = true;
        }
    }
}
