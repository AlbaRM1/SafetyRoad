using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField] private GameObject[] _text;

    private void Start()
    {
        var result = GameObject.Find("Content");

        Instantiate(_text[0], result.transform);
    }
}
