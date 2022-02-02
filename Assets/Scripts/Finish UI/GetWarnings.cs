using UnityEngine;
using UnityEngine.EventSystems;

public class GetWarnings : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _wearWarning;
    [SerializeField] private GameObject _crosswalkWarning;

    private PlayerScore _playerScore;
    private GameObject _warningWindow;
    private GameObject _contentWindow;

    public void OnPointerClick(PointerEventData eventData)
    {
        _playerScore = GameObject.FindGameObjectWithTag("MainPlayer").GetComponent<PlayerScore>();
        _warningWindow = eventData.pointerPress.transform.parent.transform.parent.transform.parent.Find("Warning window").gameObject; // Получаем окно ошибок

        _contentWindow = _warningWindow.transform.Find("Warnings").transform.Find("Viewport").Find("Content").gameObject;

        _warningWindow.SetActive(true);

        if (_playerScore.Warning.Count != 0)
        {

            foreach (var error in _playerScore.Warning)
            {
                if (error == "Wear")
                {
                    Instantiate(_wearWarning, _contentWindow.transform);
                    Debug.Log("Wear");
                }

                if (error == "CrosswalkWarn")
                {
                    Instantiate(_crosswalkWarning, _contentWindow.transform);
                    Debug.Log("Crosswalk");
                }
            }
        }
    }
}
