using UnityEngine;
using UnityEngine.EventSystems;

public class Resume : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _UI;
    private GameObject PauseMenu;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        PauseMenu = _UI.transform.Find("Pause Menu").gameObject;
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
}
