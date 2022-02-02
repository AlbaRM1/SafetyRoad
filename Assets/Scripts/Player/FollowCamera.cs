using UnityEngine;
using Cinemachine;


public class FollowCamera : MonoBehaviour
{
    private CinemachineVirtualCamera _vcam;
    private Transform _player;

    void Start()
    {
        _vcam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        _player = GameObject.FindGameObjectWithTag("MainPlayer").transform;
        _vcam.m_Follow = _player;
        _vcam.m_LookAt = _player;
    }
}
