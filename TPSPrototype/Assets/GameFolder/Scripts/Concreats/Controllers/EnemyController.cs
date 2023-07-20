using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.Abstracts.Controllers;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Animations;
using TPSPrototype.Combats;
using TPSPrototype.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace TPSPrototype.Controllers 
{
    public class EnemyController : MonoBehaviour, IEntityController
    {
        public Transform Controller => transform;
        [SerializeField] GameObject _playerPref;
        IMover _mover;
        IHealth _health;
        EnemyAnimation _enemyAnimation;

        private void Awake()
        {
            _mover = new NavMeshMover(this);
            _enemyAnimation = new EnemyAnimation(this);
            _health = GetComponent<IHealth>();
        }
        private void FixedUpdate()
        {
            if (_health.IsDead) { return; }
            _mover.MoveAction(_playerPref.transform.position);
            
        }
        private void LateUpdate()
        {
            _enemyAnimation.SetMoveAnimation();
        }


    }

}

