using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public float openAngle = 90f;  // 门打开角度
    public float speed = 3f;       // 平滑旋转速度
    public Vector3 pivotOffset = new Vector3(-0.5f, 0, 0);
    private Quaternion closedRotation;
    private Quaternion openRotation;
    private bool isOpen = false;

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + openAngle, transform.eulerAngles.z);
    }

    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,
            isOpen ? openRotation : closedRotation,
            Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true; // 玩家靠近 → 打开门
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = false; // 玩家离开 → 关门
        }
    }
}
