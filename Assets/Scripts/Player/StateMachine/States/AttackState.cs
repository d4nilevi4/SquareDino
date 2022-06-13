using UnityEngine;

public class AttackState : State
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _shootingPoint;

    private RaycastHit _hit;
    private Camera _mainCamera;

    protected override void Init()
    {
        base.Init();
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out _hit))
            {
                animator.SetTrigger("Shoot");
                transform.LookAt(_hit.point);
                Instantiate(_bullet, _shootingPoint.position, Quaternion.identity);
            }
        }
    }

    public RaycastHit GetHitPoint()
    {
        return _hit;
    }
}
