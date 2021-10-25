using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Carnation/Action/Idle")]
public class Shoot : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("idle", false);
        //controller.SetAnimation("attack", false);
        controller.SetAnimation("shoot", true);
    }
}
