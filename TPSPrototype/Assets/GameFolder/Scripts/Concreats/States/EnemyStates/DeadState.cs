using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using UnityEngine;

namespace TPSPrototype.EnemyStates 
{
    public class DeadState : IState
    {
        public void OnEnter()
        {
            Debug.Log($"{nameof(DeadState)}{nameof(OnEnter)}");
        }

        public void OnExit()
        {
            Debug.Log($"{nameof(DeadState)}{nameof(OnExit)}");
        }

        public void Tick()
        {
            
        }
    }
}

