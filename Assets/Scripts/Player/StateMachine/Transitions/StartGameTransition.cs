using UnityEngine;

public class StartGameTransition : Transition
{
    [SerializeField] private UIController _uIController;
    [SerializeField] private CameraControl _camera;

    private void Update()
    {
        if (_uIController.IsGameStart)
        {
            _camera.stageId = 1;
            NeedTransit = true;
        }
            
    }
}
