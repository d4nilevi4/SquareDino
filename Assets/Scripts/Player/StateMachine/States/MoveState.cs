using UnityEngine;
using UnityEngine.AI;

public class MoveState : State
{
    private NavMeshAgent _agent;

    protected override void Init()
    {
        base.Init();
        _agent = GetComponent<NavMeshAgent>();
        animator.SetBool("isRun", true);
    }

    private void Update()
    {
        _agent.SetDestination(Player.CurrentPoint.position);
    }
}
