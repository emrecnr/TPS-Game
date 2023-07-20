using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Controllers;
using TPSPrototype.Controllers;
using UnityEngine;
using UnityEngine.AI;

namespace TPSPrototype.Animations 
{
    public class EnemyAnimation 
    {
        Animator _enemyAnimator;
        NavMeshAgent _navMeshAgent;
        public EnemyAnimation(IEntityController entityController)
        {
            _enemyAnimator = entityController.Controller.GetComponentInChildren<Animator>();
            _navMeshAgent = entityController.Controller.GetComponentInParent<NavMeshAgent>();
        }

        public void SetMoveAnimation()
        {
            _enemyAnimator.SetFloat("moveSpeed", _navMeshAgent.velocity.magnitude);
            Debug.Log(_enemyAnimator);
        }
    }

}

