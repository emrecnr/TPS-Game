using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Controllers;
using TPSPrototype.Abstracts.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace TPSPrototype.Movements
{
    public class NavMeshMover : IMover
    {
        float _moveSpeed = 2f;
        NavMeshAgent _enemyAgent;
        public NavMeshMover(IEntityController entityController)
        {
            _enemyAgent = entityController.Controller.GetComponent<NavMeshAgent>();
        }
        public void MoveAction(Vector3 direction)
        {
            _enemyAgent.SetDestination(direction);
            _enemyAgent.speed = _moveSpeed;
        }
    }


}


