﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
      

    void Start () {
        List<Dictionary<string, object>> data = CSVReader.Read("EventLog");

        Debug.Log(data.Count.ToString());
	}
	
	
	void Update () {
       
    }
}
