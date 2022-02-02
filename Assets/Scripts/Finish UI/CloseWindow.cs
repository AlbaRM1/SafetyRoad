using UnityEngine;
using UnityEngine.EventSystems;

public class CloseWindow : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject window = eventData.pointerClick.gameObject.transform.parent.gameObject;

        if (window.transform.Find("Errors"))
        {
            var forDelete = window.transform.Find("Errors").transform.Find("Viewport").transform.Find("Content").transform;

            foreach (Transform item in forDelete)
            {
                Destroy(item.gameObject);
            }
        }

        if (window.transform.Find("Warnings"))
        {
            var forDelete = window.transform.Find("Warnings").transform.Find("Viewport").transform.Find("Content").transform;

            foreach (Transform item in forDelete)
            {
                Destroy(item.gameObject);
            }
        }

        window.SetActive(false);
    }
}
