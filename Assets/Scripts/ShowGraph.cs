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
    private double[] axis = new double[16];


    public void SetGraph() // 그래프에 그려질 각 점의 value에 myData를 대입하는 함수
    {
        int temp = 0;
        foreach (var item in myData)
        {
            axis[temp++] = item;
        }
    }

    public void DrawGraph() // 그래프를 구현하는 함수
    {
        GameObject tempObject;
        Transform tempform = Orientation.transform;
        foreach (var item in axis)
        {
            tempObject = Instantiate(point, tempform.position + (float)item * Vector3.up, tempform.rotation);
            tempObject.GetComponent<PlotPoint>().value = (float)item;
            tempform.position = tempform.position + Vector3.right;
        }
    }
}

class GraphData : Queue<double> // 최대 크기가 16으로 고정된 Queue<double>, 값 입력시 LimitEnque 이용
{
    public GraphData() : base(16)
    {

    }

    public GraphData(double data) : this()
    {
        Enqueue(data);
    }

    public void LimitEnque(double data)
    {
        if (Count == 16)
        {
            Dequeue();
            Enqueue(data);
        }
    }
}
