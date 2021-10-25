using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace FSM
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Act(Controller controller);
    }
}
