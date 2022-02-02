using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeHat : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject[] mesh_hats;
    private int index;

    public void OnPointerClick(PointerEventData eventData)   // При клике на кнопку "Сменить шапку"
    {
        for (int i = 0; i < mesh_hats.Length; i++)
        {
            if (mesh_hats[i].activeSelf == true)
            {
                index = i;
            }
        }
        if (index == mesh_hats.Length - 1)
        {
            mesh_hats[index].SetActive(false);
            mesh_hats[0].SetActive(true);

            return;
        }

        mesh_hats[index].SetActive(false);
        mesh_hats[index + 1].SetActive(true);
    }
}