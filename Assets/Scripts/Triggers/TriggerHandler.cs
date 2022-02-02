using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Color _startColor = new Color(0, 0, 0, 0);

    private void OnTriggerStay(Collider collider)
    {

        _meshRenderer = collider.gameObject.GetComponent<MeshRenderer>();

        _meshRenderer.material.shader = Shader.Find("Transparent/Diffuse");
    }

    private void OnTriggerExit(Collider collider)
    {
        _meshRenderer.material.shader = Shader.Find("Mobile/Diffuse");
        _meshRenderer.material.color = _startColor;
    }
}
