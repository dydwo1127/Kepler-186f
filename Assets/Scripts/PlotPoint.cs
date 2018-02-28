using UnityEngine;
using UnityEngine.UI;
public class PlotPoint : MonoBehaviour
{
	public GameObject Tooltip;
    public float value { get; set; }

	private GameObject present;

    void OnMouseEnter()
    {
        // 값을 툴팁 형식으로 표시, 우선은 debug.log 통해 표시
        Debug.Log(value);
		present = Instantiate(Tooltip);
		present.GetComponent<Text>().text = value.ToString();
		present.GetComponent<RectTransform>().SetParent (transform);
		present.GetComponent<RectTransform>().localPosition = Vector3.zero;
		present.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		present.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		present.GetComponent<RectTransform>().anchoredPosition = new Vector2 (0f, 20f);
		present.GetComponent<RectTransform>().localScale = Vector3.one;
		Debug.Log ("Instantiated");
    }

	void OnMouseExit()
	{
		Destroy(present);
		Debug.Log ("Destroyed");
	}
}
