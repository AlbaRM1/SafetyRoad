using UnityEngine;
using UnityEngine.EventSystems;

public class GetErrors : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _crossWalkError;
    [SerializeField] private GameObject _roadError;

    private PlayerScore _playerScore;
    private GameObject _errorsWindow;
    private GameObject _contentWindow;

    public void OnPointerClick(PointerEventData eventData)
    {
        _playerScore = GameObject.FindGameObjectWithTag("MainPlayer").GetComponent<PlayerScore>();
        _errorsWindow = eventData.pointerPress.transform.parent.transform.parent.transform.parent.Find("Errors window").gameObject; // Получаем окно ошибок

        _contentWindow = _errorsWindow.transform.Find("Errors").transform.Find("Viewport").Find("Content").gameObject;

        _errorsWindow.SetActive(true);

        if (_playerScore.Errors.Count != 0)
        {
            foreach (var error in _playerScore.Errors)
            {
                Debug.Log(error);

                if (error == "Road")
                {
                    Instantiate(_roadError, _contentWindow.transform);
                }

                if (error == "CrosswalkErr")
                {
                    Debug.Log("CrosswalkErr");
                    Instantiate(_crossWalkError, _contentWindow.transform);
                }
            }
        }
    }
}
