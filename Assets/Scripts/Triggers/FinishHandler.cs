using UnityEngine;

namespace MyProject
{
    public class FinishHandler : MonoBehaviour
    {
        private GameObject _UI;
        private GameObject _finishMenu;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "MainPlayer")
            {
                _UI = GameObject.FindGameObjectWithTag("UI");

                var playerScore = collider.GetComponent<PlayerScore>();

                _finishMenu = _UI.transform.Find("Finish").gameObject;
                var panel = _finishMenu.transform.Find("Panel").gameObject;

                var errors = panel.transform.Find("Errors");
                errors.GetComponent<TMPro.TextMeshProUGUI>().text = $"Ошибок: {playerScore.Errors.Count}";

                var warning = panel.transform.Find("Warnings");
                warning.GetComponent<TMPro.TextMeshProUGUI>().text = $"Предупреждений: {playerScore.Warning.Count}";

                Time.timeScale = 0;
                _finishMenu.SetActive(true);
            }
        }
    }
}
