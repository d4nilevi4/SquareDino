using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Transform _firstPoint;
    [SerializeField] private Transform _secondPoint;
    [SerializeField] private Transform _thirdPoint;

    public int stageId = 0;

    private void Update()
    {
        if (transform.position != _firstPoint.position && stageId == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, _firstPoint.position, _moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, _firstPoint.rotation, _rotationSpeed);
        }

        if (transform.position != _secondPoint.position && stageId == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, _secondPoint.position, _moveSpeed * 1.5f * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, _secondPoint.rotation, _rotationSpeed);
        }

        if (transform.position != _thirdPoint.position && stageId == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, _thirdPoint.position, _moveSpeed * 1.5f * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, _thirdPoint.rotation, _rotationSpeed);
        }
    }
}
