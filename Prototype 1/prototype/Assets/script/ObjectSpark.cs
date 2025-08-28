using UnityEngine;

public class EventObject : MonoBehaviour
{
    public Material normalMaterial;
    public Material highlightMaterial;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = normalMaterial;
    }

    public void Highlight()
    {
        rend.material = highlightMaterial; // 被选中时发亮
    }

    public void UnHighlight()
    {
        rend.material = normalMaterial; // 取消高亮
    }
}
