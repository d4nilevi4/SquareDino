using UnityEngine;

public class DistanceTransition : Transition
{
    private void Update()
    {
        if (transform.position == new Vector3(Player.CurrentPoint.position.x, transform.position.y, Player.CurrentPoint.position.z))
        {
            animator.SetBool("isRun", false);
            NeedTransit = true;
        }
            
    }
}
