using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ResourceManagement;

public class ShowGraph : MonoBehaviour
{
    public GameObject point; // 클래스 PlotPoint를 가지고 있는 prefab
    public GameObject Orientation;
    private GraphData myData;
    private ResourceData SectorR;
    private double[] axis = new double[16];
    private Queue<GameObject> Points;

    void Start()
    {
        myData = new GraphData();
        SectorR = new ResourceData();
        Points = new Queue<GameObject>();
    }

    public void DrawGraph(string key) // 그래프를 구현하는 함수
    {
        myData.LimitEnque(SectorR[key]);
        float interval = 175/16;
        GameObject tempObject;
        Vector3 tempform = Vector3.zero;
        foreach (var item in myData)
        {
            Debug.Log("foreach:" + item);
            tempObject = Instantiate(point);
            tempObject.transform.SetParent(Orientation.transform);
            tempObject.GetComponent<RectTransform>().localPosition = tempform + (float)item * Vector3.up;
            tempObject.GetComponent<PlotPoint>().value = (float)item;
            tempform += interval * Vector3.right;
            Points.Enqueue(tempObject);
        }
    }

    void OnDisable()
    {
        foreach (var item in Points)
        {
            Destroy(item);
        }
    }
    
    public void DrawIt()
    {
        SectorR["O2"] = 100f;
        DrawGraph("O2");
    }
}

class GraphData : Queue<double> // 최대 크기가 16으로 고정된 Queue<double>, 값 입력시 LimitEnque 이용
{
    public GraphData() : base(16)
    {
        for (int i = 0; i < 15; i++)
        {
            Enqueue(0f);
        }
    }

    public GraphData(double data) : this()
    {
        Enqueue(data);
    }

    public void LimitEnque(double data)
    {
        if (Count > 15)
        {
            Dequeue();
            Enqueue(data);
        }
        else Enqueue(data);
    }
}
