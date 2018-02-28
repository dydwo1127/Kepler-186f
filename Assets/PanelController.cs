using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerData;

public class PanelController : MonoBehaviour {

    public static int numberOfEvent = 4;
    public Text[] EventText = new Text[numberOfEvent];
    public Text[] EventText_long = new Text[numberOfEvent];
    public GameObject EventPanel;


    string[,] data = new string[2,numberOfEvent];
    void Start () {
        foreach (Text element in EventText)
        {
            element.text = "";
        }
        foreach (Text element in EventText_long)
        {
            element.text = "";
        }

        GameObject EventPanel = GetComponent<GameObject>();
       

        for (int i = 0; i < numberOfEvent; i++)
        {
            for (int x = 1; x < 3; x++)
            {
                data[x-1,i] = Parser.ExtractFromMatrix(Resources.Load<TextAsset>("EventLog").text, x,i);
            }
        }
    }


	
	// Update is called once per frame
	void Update ()//숫자수정필요
    {
        if (ShipData.TurnCount <= 7)
        {
            EventText[0].text = data[0, 0];

        }
        //.. turncount 따라 정리 필요 이벤트 구현 후 정리

        
        
	}
}
