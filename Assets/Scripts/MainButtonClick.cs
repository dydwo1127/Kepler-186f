using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonClick : MonoBehaviour
{
    /*
     * 메인 메뉴의 버튼 클릭 함수 모음입니다.
     */

    public GameObject credit;
    private bool showCredit;

    void Start()
    {
        showCredit = false;
        credit.SetActive(false);
    }
    void Update()
    {
        if (showCredit && Input.GetMouseButtonDown(0))
        {
            showCredit = false;
            credit.SetActive(false);
        }
    }

    public void NewGame()
    {
        // 시나리오 선택

        // 새 게임 시작

        SceneManager.LoadScene("Sector");
    }

    public void Load()
    {
        // 파일 읽어들임
        // 파싱
        // 데이터 대입 및 씬 로드
        
    }

    public void Credit()
    {
        credit.SetActive(true);
        showCredit = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
