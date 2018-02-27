using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuShipMove : MonoBehaviour
{
    public GameObject ship;
    private Vector3 MouseStart;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("1");
                MouseStart = Input.mousePosition;
            }
            else
            {
                Debug.Log("2");
                ship.transform.rotation *= Quaternion.Euler(0, 2 * Quaternion.FromToRotation(Input.mousePosition, MouseStart).eulerAngles.magnitude, 0);
                MouseStart = Input.mousePosition;
            }
            
        }
    }
    
}
