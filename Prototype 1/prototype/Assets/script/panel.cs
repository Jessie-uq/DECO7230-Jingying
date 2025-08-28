using UnityEngine;

public class TimePanelController : MonoBehaviour
{
    public GameObject timePanel; // 拖你的UI面板进来

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T pressed, panel active? " + timePanel.activeSelf);
            timePanel.SetActive(!timePanel.activeSelf); // 切换显示/隐藏
        }
    }
}
