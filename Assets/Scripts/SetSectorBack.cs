using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSectorBack : MonoBehaviour
{
    public GameObject SM;

	void OnMouseDown()
    {
        SM.GetComponent<ScreenManager>().SpecSector(0);
    }
}
