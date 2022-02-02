using UnityEngine;

public class CrosswalkScript : MonoBehaviour
{
    private GameObject _lookAround;
    private PlayerScore _playerScore;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainPlayer")
        {
            _lookAround = GameObject.Find("UI(Clone)").transform.Find("Look Around").gameObject;
            _lookAround.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MainPlayer")
        {
            _playerScore = collider.gameObject.GetComponent<PlayerScore>();

            _lookAround.SetActive(false);

            var LookAround = _lookAround.GetComponent<LookAround>();
            var LookAroundAmount = LookAround.LookAroundAmount;

            if ((int)LookAroundAmount == 0)
            {
                _playerScore.Errors.Add("CrosswalkErr");
            }
            else if (LookAroundAmount > 0 && LookAroundAmount < 2)
            {
                _playerScore.Warning.Add("CrosswalkWarn");
            }
        }
    }
}
