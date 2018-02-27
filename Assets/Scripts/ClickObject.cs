using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public static bool disable;
    public GameObject SM;
    public GameObject nextUI;
    private ScreenManager sm;

    void Start()
    {
        sm = SM.GetComponent<ScreenManager>();
    }

    void OnMouseEnter()
    {
        // turn on Outline
        if (!disable)
        {
            Debug.Log("IN");
        }
    }

    void OnMouseExit()
    {
        // turn off Outline
        if (!disable)
        {
            Debug.Log("OUT");
        }
    }

    void OnMouseDown()
    {
        if (!disable)
        {
            sm.UIChange(nextUI);
            disable = true;
        }
    }
}
