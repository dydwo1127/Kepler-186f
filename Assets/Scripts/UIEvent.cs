using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Parser;


// 이벤트 상세화면 변경을 위한 스크립트입니다
public class UIEvent : MonoBehaviour
{
	public GameObject GO_EventList;
	public GameObject GO_EventSpec;
	//public EventList events;
	public GameObject Text_story;
	public GameObject Text_effect;
	public GameObject SM;

	private string story;
	private string effect;

	void Start()
	{
		// enabled = Some Event Management;
	}

//	public void Eventlist()
//	{
//		foreach (var item in enabled) 
//		{
//			
//		}
//	}

	public void ChooseEvent(int num)
	{
		//story = ExtractFromMatrix (buffer, num, 3);
		// effect = events[num][2];
		GO_EventSpec.SetActive(true);
		GO_EventList.SetActive(false);

		//Text_story.GetComponent<Text>().text = story;
		//Text_effect.GetComponent<Text> ().text = effect;
	}

	public void GoBack(GameObject before)
	{
		if (GO_EventSpec.activeSelf) {
			GO_EventList.SetActive (true);
			GO_EventSpec.SetActive (false);
		} else
		{
			SM.GetComponent<ScreenManager>().UIChange(before);
		}
	}

}
