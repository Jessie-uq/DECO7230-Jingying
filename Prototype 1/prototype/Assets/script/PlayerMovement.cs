using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float baseSpeed = 5f;            // 原始移动速度
    public float mouseSensitivity = 50f;    // 鼠标灵敏度
    public Transform playerCamera;          // 玩家相机
    public Transform worldRoot;             // 场景根物体，用于获取缩放比例

    float xRotation = 0f; // 相机竖直方向的旋转角度

    void Start()
    {
        // 隐藏并锁定鼠标到屏幕中心
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // 根据世界缩放自动调整速度
        float scaleFactor = worldRoot != null ? worldRoot.localScale.x : 1f;
        float speed = baseSpeed / scaleFactor;

        // 1. 玩家移动
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        transform.Translate(move * speed * Time.deltaTime, Space.Self);

        // 2. 鼠标控制视角
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 相机上下旋转（俯视/仰视）
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // 玩家身体左右旋转
        transform.Rotate(Vector3.up * mouseX);
    }
}
