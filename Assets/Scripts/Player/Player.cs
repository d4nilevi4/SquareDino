using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
  
    private Transform _currentPoint;
    private int _nextWayPointId;


    public Transform CurrentPoint => _currentPoint;
    public Transform LastPoint => _wayPoints[_wayPoints.Length - 1];

    private void Start()
    {
        _currentPoint = _wayPoints[1];
        _nextWayPointId = 2;

        transform.position = _wayPoints[0].position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().Play("Shooting");
        }
    }

    public void SetNextWayPoint()
    {
        _currentPoint = _wayPoints[_nextWayPointId];
        _nextWayPointId++;
    }
}
