using UnityEngine;
using UnityEngine.EventSystems;

public class Sprint : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private GameObject _player;
    [SerializeField] private float _speed;

    private float _startSpeed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _player = GameObject.FindGameObjectWithTag("MainPlayer");

        _startSpeed = _player.GetComponent<PlayerController>().MoveSpeed;

        _player.GetComponent<PlayerController>().MoveSpeed = _speed;
        _player.GetComponent<CubePeople.AnimationController>().AnimName = "Run";
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _player.GetComponent<CubePeople.AnimationController>().anim.SetFloat("Run", 0f);
        _player.GetComponent<PlayerController>().MoveSpeed = _startSpeed;
        _player.GetComponent<CubePeople.AnimationController>().AnimName = "Walk";
    }
}
