using UnityEngine;
using UnityEngine.EventSystems;

public class LookAround : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
{
    private GameObject _body;
    public int LookAroundAmount;

    public void OnPointerClick(PointerEventData eventData)
    {
        _body = GameObject.FindGameObjectWithTag("Bip001 Spine");
        _body.GetComponent<CustomAnimationController>().ChangeAnimation("isLooking", true);

        LookAroundAmount++;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        _body.GetComponent<CustomAnimationController>().ChangeAnimation("isLooking", false);
    }
}
