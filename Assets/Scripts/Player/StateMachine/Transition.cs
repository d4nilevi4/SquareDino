using UnityEngine;

public abstract class Transition : MonoBehaviour
{
    [SerializeField] private State _targetState;

    protected Animator animator;

    protected Player Player { get; set; }
    public State TargetState => _targetState;

    public bool NeedTransit { get; protected set; }

    private void OnEnable()
    {
        Init();
    }

    public void Enter(Player player)
    {
        Player = player;
    }

    protected virtual void Init()
    {
        NeedTransit = false;
        animator = GetComponent<Animator>();
    }
}
