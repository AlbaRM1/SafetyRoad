using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainPlayer") { }
    }
}
