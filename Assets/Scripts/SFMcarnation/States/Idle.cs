using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FSM;

[CreateAssetMenu(menuName = "FSM/Carnation/Action/Idle")]
public class Idle : FSM.Action
{
    public override void Act(Controller controller)
    {
        controller.SetAnimation("idle", true);
        //controller.SetAnimation("attack", false);
        controller.SetAnimation("shoot", false);
    }
}
