using UnityEngine;
using UnityEngine.AI;

public class CalculatePath : MonoBehaviour
{
    [SerializeField] private GameObject _drawerLines;
    [SerializeField] private GameObject _positionA;
    [SerializeField] private GameObject _positionB;
    private GameObject _playerPosition;

    NavMeshPath MeshAgentPath;

    public void CalculatePathAuto(Transform _playerPosition)
    {
        NavMesh.CalculatePath(_playerPosition.position, _positionB.transform.position, NavMesh.AllAreas, MeshAgentPath);

        if (MeshAgentPath.status == NavMeshPathStatus.PathPartial)
        {
            _drawerLines.GetComponent<LineRenderer>().positionCount = MeshAgentPath.corners.Length;
            _drawerLines.GetComponent<LineRenderer>().SetPositions(MeshAgentPath.corners);
        }
    }

}
