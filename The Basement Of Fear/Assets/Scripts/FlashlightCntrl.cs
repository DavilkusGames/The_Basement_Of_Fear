using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightCntrl : MonoBehaviour
{
    [SerializeField]
    private GameObject flashlight;

    private bool state = false;

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            state = !state;
            flashlight.SetActive(state);
        }
	}
}
