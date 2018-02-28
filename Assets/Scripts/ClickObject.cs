using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public static bool disable;

    public GameObject SM;
    private ScreenManager sm;

    public Material Highlighted;
    public Material DefaultM;
    public GameObject nextUI;

    void Start()
    {
        sm = SM.GetComponent<ScreenManager>();
        disable = false;
    }

    void OnMouseEnter()
    {
        if (!disable)
        {
            GetComponent<Renderer>().material = Highlighted;
        }
    }
    
    void OnMouseExit()
    {
        if (!disable)
        {
            GetComponent<Renderer>().material = DefaultM;
        }
    }

    void OnMouseDown()
    {
        if (!disable)
        {
            sm.UIChange(nextUI);
            GetComponent<Renderer>().material = DefaultM;
            disable = true;
        }
    }
}
