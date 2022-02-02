
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SaveSpawnPOsition : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        DataHolder.PlayerSpawnPosition = eventData.rawPointerPress;

        SceneManager.LoadScene("StreetScene", LoadSceneMode.Additive);
    }
}
