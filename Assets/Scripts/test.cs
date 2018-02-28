using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    
    void Start () {
        var data = Parser.ExtractFromMatrix(Resources.Load<TextAsset>("EventLog").text, 1, 1);
        Debug.Log(data);
	}
	
	void Update () {
       
    }
}
