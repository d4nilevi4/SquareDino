using UnityEngine;

public class VictoryTransition : Transition
{
    private void Update()
    {
        if (transform.position == new Vector3(Player.LastPoint.position.x, transform.position.y, Player.LastPoint.position.z))
        {
            NeedTransit = true;
        }
    }
}
