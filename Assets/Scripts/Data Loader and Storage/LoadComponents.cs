using UnityEngine;
using UnityEngine.AI;

public class LoadComponents : MonoBehaviour
{
    private GameObject _player;
    private GameObject _ui;
    private GameObject _playerSpawnPosition;

    [SerializeField] private GameObject _drawerLines;
    [SerializeField] private GameObject _positionB;

    NavMeshPath MeshAgentPath;

    private void Awake()
    {
        _player = DataHolder.Player;
        _ui = DataHolder.UI;
        _playerSpawnPosition = DataHolder.PlayerSpawnPosition;
    }
    private void Start()
    {
        /* Unload Scene */
        // in script AITrafficWaypointRoute.cs

        /* Setting UI */
        foreach (Transform childItem in _ui.transform)
        {
            if (childItem.gameObject.name != "Pause Menu" && childItem.gameObject.name != "Look Around" && childItem.gameObject.name != "Finish")
            {
                childItem.gameObject.SetActive(true);
            }
        }

        /* Spawn UI */
        Instantiate(_ui);

        /* Get and Set components */
        _player.GetComponent<PlayerController>().Joystick = FindObjectOfType<FixedJoystick>();
        _player.GetComponent<PlayerController>().MoveSpeed = 2f;

        _player.GetComponent<CubePeople.AnimationController>().enabled = true;
        _player.GetComponent<CubePeople.AnimationController>().Joystick = FindObjectOfType<FixedJoystick>();

        GameObject.FindGameObjectWithTag("Bip001 Spine").GetComponent<CustomAnimationController>().enabled = true;

        /* Warning detection */
        foreach (Transform clothes in _player.transform)
        {
            if (clothes.gameObject.activeSelf == true && clothes.tag == "BlackClothes")
            {
                var score = _player.GetComponent<PlayerScore>();
                score.Warning.Add("Wear");
            }
        }

        foreach (Transform hat in _player.transform.Find("Bip001").transform.Find("Bip001 Pelvis").transform.Find("Bip001 Spine").transform.Find("Bip001 Spine1").transform.Find("Bip001 Neck").transform.Find("Bip001 Head"))
        {
            if (hat.gameObject.activeSelf == true && hat.tag == "BlackClothes")
            {
                var score = _player.GetComponent<PlayerScore>();
                score.Warning.Add("Wear");
            }
        }

        /* Spawn player */
        Instantiate(_player, new Vector3(_playerSpawnPosition.gameObject.transform.position.x, 0.2f, _playerSpawnPosition.gameObject.transform.position.z), Quaternion.identity);

        /* Calculate path */
        CalculatePathAuto(new Vector3(_playerSpawnPosition.gameObject.transform.position.x, 0.3f, _playerSpawnPosition.gameObject.transform.position.z));
    }

    private void CalculatePathAuto(Vector3 _playerPosition)
    {
        MeshAgentPath = new NavMeshPath();

        NavMesh.CalculatePath(_playerPosition, _positionB.transform.position, NavMesh.AllAreas, MeshAgentPath);

        if (MeshAgentPath.status == NavMeshPathStatus.PathComplete)
        {
            _drawerLines.GetComponent<LineRenderer>().positionCount = MeshAgentPath.corners.Length;
            _drawerLines.GetComponent<LineRenderer>().SetPositions(MeshAgentPath.corners);
        }
    }

}
