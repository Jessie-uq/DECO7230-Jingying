using UnityEngine;

public class PictureZoomTrigger : MonoBehaviour
{
    public Vector3 normalScale = new Vector3(1f, 1f, 1f); // 原始大小
    public Vector3 zoomedScale = new Vector3(2f, 2f, 2f); // 放大后的大小
    public float zoomSpeed = 5f; // 缩放速度（平滑过渡用）

    private bool isZoomed = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isZoomed = true; // 进入 → 放大
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isZoomed = false; // 离开 → 还原
        }
    }

    void Update()
    {
        // 平滑缩放（用Lerp）
        Vector3 targetScale = isZoomed ? zoomedScale : normalScale;
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * zoomSpeed);
    }
}
