using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Restart : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadSceneAsync("CustomizationPlayer");
        Time.timeScale = 1;
    }
}
