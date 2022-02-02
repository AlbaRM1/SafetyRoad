using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SaveCustomizationAndNextLevel : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _ui;
    [SerializeField] GameObject[] _gameObjectsForDisactivate;

    public void OnPointerClick(PointerEventData eventData)
    {
        _ui.SetActive(true);

        DataHolder.Player = _player;
        DataHolder.UI = _ui;

        foreach (var gameObject in _gameObjectsForDisactivate)
        {
            gameObject.SetActive(false);
        }

        SceneManager.LoadScene("SelectStartPointScene", LoadSceneMode.Additive);
    }
}
