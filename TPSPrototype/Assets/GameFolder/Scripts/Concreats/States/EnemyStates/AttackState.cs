using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using UnityEngine;

namespace TPSPrototype.EnemyStates
{
    public class AttackState : IState
    {
        public void OnEnter()
        {
            Debug.Log($"{ nameof(AttackState)}{ nameof(OnEnter)}");
        }

        public void OnExit()
        {
            Debug.Log($"{nameof(AttackState)}{nameof(OnExit)}");
        }

        public void Tick()
        {
            
        }
    }
}

