using UnityEngine;

public class AttackTransition : Transition
{
    [SerializeField] private float _distanceToTransit;
    [SerializeField] private CameraControl _camera;

    private Enemy[] _enemies;

    protected override void Init()
    {
        base.Init();
        _enemies = FindObjectsOfType<Enemy>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.SetNextWayPoint();
            NeedTransit = true;
        }

        foreach (var enemy in _enemies)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position) <= _distanceToTransit && !enemy.IsDie)
            {
                return;
            }
            if (Vector3.Distance(transform.position, enemy.transform.position) > _distanceToTransit && !enemy.IsDie)
            {
                continue;
            }
        }

        Player.SetNextWayPoint();
        _camera.stageId++;
        NeedTransit = true;
    }
}
