using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f;    // 开门角度
    public float speed = 2f;         // 转动速度
    private bool isOpen = false;     // 状态：关着还是开着
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    void Update()
    {
        // 平滑旋转
        if (isOpen)
            transform.rotation = Quaternion.Slerp(transform.rotation, openRotation, Time.deltaTime * speed);
        else
            transform.rotation = Quaternion.Slerp(transform.rotation, closedRotation, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = !isOpen; // 每次碰到玩家就切换一次
        }
    }
}
