using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using UnityEngine;

namespace TPSPrototype.EnemyStates
{
    public class ChaseState : IState
    {
        public void OnEnter()
        {
            Debug.Log($"{nameof(ChaseState)}{nameof(OnEnter)}");
        }

        public void OnExit()
        {
            Debug.Log($"{nameof(ChaseState)}{nameof(OnExit)}");
        }

        public void Tick()
        {
            
        }
    }
}

