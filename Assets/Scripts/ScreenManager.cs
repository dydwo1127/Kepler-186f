using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour {

    /*
     *  class ScreenManager
     *  스크린 및 UI의 전반적인 조작을 관리하는 클래스입니다.
     */

    private int specSec; // SectorUI에서 표시되는 섹터 번호 (미선택시 0)

    public GameObject GO_state; // 현재 표시되는 gameobject 및 초기 지정 state
    private GameObject GO_nextstate; // 씬 전환시 임시적으로 사용하는 gameobject
    private GameObject GO_formerstate; // 이전 state

    public GameObject GO_Sec_over; // 섹터UI에서의 오버뷰 UI
    public GameObject GO_Sec_spec; // 섹터UI에서의 상세화면 UI
    public GameObject GO_Sec_spec_text;
    public GameObject GO_Pause;  // 일시정지창

    void Start()
    {
        specSec = 0;
        GO_formerstate = GO_state;
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (GO_formerstate != GO_state)
            {
                UIChange(GO_formerstate);
            }
            else
            {
                UIChange(GO_Pause);
            }
        }
		if (Input.GetKeyDown(KeyCode.F1))
		{
			UnityEditor.EditorApplication.isPaused = true;
		}
    }
    // UIChange : Fadein 코루틴을 실행
    public void UIChange(GameObject nextState) 
    {
        GO_nextstate = nextState;
        StartCoroutine("Fadein");
        if (ClickObject.disable)
        {
            ClickObject.disable = false;
        }
    }


    // SpecSector : 섹터UI에서 토글 그룹을 통한 상세 섹터화면을 전환
    public void SpecSector(int currentSec)
    {
        if (currentSec == 0)
        {
            GO_Sec_over.SetActive(true);
            GO_Sec_spec.SetActive(false);
            specSec = 0;
        }
        else if (currentSec > 0 && currentSec < 9)
        {
            if (specSec != currentSec)
            {
                GO_Sec_spec.SetActive(true);
                GO_Sec_over.SetActive(false);
                specSec = currentSec;
                SectorResources(specSec);
            }
            else
            {
                GO_Sec_over.SetActive(true);
                GO_Sec_spec.SetActive(false);
                specSec = 0;
            }
        }
        else
        {
            Debug.Log("error occured: please input appropriate value");
        }

    }
    
    public void SectorResources(int num)
    {
        string tempText;
        tempText = string.Format("섹터: {0}\n인구수: {1}\n자원: {2}", num, 0, 0);

        GO_Sec_spec_text.GetComponent<Text>().text = tempText;
    }



    IEnumerator Fadein()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    // Some animation
        //    yield return null;
        //}
        //UI 변경
        GO_state.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        GO_nextstate.SetActive(true);
        //for (int i = 0; i < 9; i++)
        //{
        //    // Some animation
        //    yield return null;
        //}

        GO_state = GO_nextstate;
    }

}
