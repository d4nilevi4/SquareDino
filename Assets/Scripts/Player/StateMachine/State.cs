using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions;

    protected Animator animator;

    protected Player Player { get; set; }

    private void OnEnable()
    {
        Init();
    }

    protected virtual void Init()
    {
        animator = GetComponent<Animator>();
    }

    public void Enter(Player player)
    {
        if (!enabled)
        {
            Player = player;
            enabled = true;
            foreach (var transition in _transitions)
            {
                transition.enabled = true;
                transition.Enter(Player);
            }
        }

    }

    public void Exit()
    {
        if (enabled)
        {
            foreach (var transition in _transitions)
            {
                transition.enabled = false;
            }

            enabled = false;
        }
            
    }

    public State GetNextState()
    {
        foreach (var transition in _transitions)
        {
            if (transition.NeedTransit)
                return transition.TargetState;
        }

        return null;
    }
}
