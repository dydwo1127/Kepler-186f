using UnityEngine;
public class PlotPoint : MonoBehaviour
{
    public float value { get; set; }
    void OnMouseEnter()
    {
        // 값을 툴팁 형식으로 표시, 우선은 debug.log 통해 표시
        Debug.Log(value);
    }
}
