using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

public class Parser : MonoBehaviour{
	/*public static string ReturnAllMatrix(string input){
		string[] RowDataStrings = input.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		foreach(var row in RowDataStrings){
			row.Split(',');
		}
	}*/
	public static string ExtractFromMatrix(string text, int row, int column){
		string[] RowDataStrings = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		Debug.Log("Row Length : " + RowDataStrings.Length);
		return RowDataStrings[row].Split('\t')[column];
	}
	
	//각 행 중에 첫번째 항목 searchigWord로 시작하는 행을 찾아서 return
	public static string[] FindRowDataOf(string text, string searchingWord, char separator = '\t'){
		string[] RowDataStrings = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

		foreach(string row in RowDataStrings){
			string[] tempRowData = row.Split(separator);
			if(tempRowData[0] == searchingWord){
				return tempRowData;
			}
		}

		Debug.Log("RowData Not Found : " + searchingWord + "in " + text);
		return null;
	}
}