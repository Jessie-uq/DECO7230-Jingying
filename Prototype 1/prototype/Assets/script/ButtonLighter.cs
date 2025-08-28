using UnityEngine;

public class TimePanelButton : MonoBehaviour
{
    public EventObject targetEvent;

    public void OnClick()
    {
        // 高亮目标
        targetEvent.Highlight();

        // 可选：玩家/相机瞬间传送到事件
        // Camera.main.transform.position = targetEvent.transform.position + new Vector3(0,2,-3);
    }
}
