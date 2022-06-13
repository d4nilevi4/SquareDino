using UnityEngine;

public class VictoryState : State
{
    [SerializeField] private GameObject _restartButton;

    private void Start()
    {
        animator.SetTrigger("Victory");
        transform.LookAt(Camera.main.transform.position);
        _restartButton.SetActive(true);
    }
}
