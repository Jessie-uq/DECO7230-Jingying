using UnityEngine;

public class CorridorEntrance : MonoBehaviour
{
    public Transform corridorStart; // 走廊起点的位置

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = corridorStart.position; // 传送玩家
        }
    }
}
