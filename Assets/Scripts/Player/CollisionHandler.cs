using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private PlayerScore _playerScore;

    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "MainPlayer")
        {
            _playerScore = GameObject.FindGameObjectWithTag("MainPlayer").GetComponent<PlayerScore>();
            _playerScore.Errors.Add("Road");
        }
    }
}
