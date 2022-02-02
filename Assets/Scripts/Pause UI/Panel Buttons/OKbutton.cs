using UnityEngine;
using UnityEngine.EventSystems;

public class OKbutton : MonoBehaviour, IPointerClickHandler
{
    private GameObject _uiPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        _uiPanel = eventData.pointerPress.transform.parent.transform.parent.transform.parent.gameObject;        // Берём panel -> Finish -> Modal Window

        _uiPanel.SetActive(false);
    }
}
