using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCaster : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private GameObject priorhit;
    public GameObject SM;
    private ScreenManager sm;

    public Material Highlighted;
    public Material DefaultM;

    void Start()
    {
        priorhit = null;
        sm = SM.GetComponent<ScreenManager>();
    }

    void Update()
    {
        ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            hit.transform.gameObject.GetComponent<Renderer>().material = Highlighted;
            priorhit = hit.collider.gameObject;
            if (Input.GetMouseButtonDown(0))
            {
                sm.UIChange(priorhit.GetComponent<ClickObject>().nextUI);
                enabled = false;
            }
        }
        else if (priorhit != null)
        {
            priorhit.GetComponent<Renderer>().material = DefaultM;
        }
    }
}