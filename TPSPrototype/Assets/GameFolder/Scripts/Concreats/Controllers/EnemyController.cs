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
        NavMeshAgent _navMeshAgent;
        public Transform Controller => transform;
        [SerializeField] GameObject _playerPref;
        IMover _mover;
        IHealth _health;
        EnemyAnimation _enemyAnimation;
        EquipController _equipController;
        bool _canAttack;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _mover = new NavMeshMover(this);
            _enemyAnimation = new EnemyAnimation(this);
            _health = GetComponent<IHealth>();
            _equipController = GetComponent<EquipController>();

        }
        private void Update()
        {
            if (_health.IsDead) { return; }
            _mover.MoveAction(_playerPref.transform.position);

            _canAttack = Vector3.Distance(transform.position, _playerPref.transform.position) <= _navMeshAgent.stoppingDistance;
        }
        private void FixedUpdate()
        {
           

            if (_canAttack ) { _equipController.Equip.Fire(); }
        }
        private void LateUpdate()
        {
            _enemyAnimation.SetMoveAnimation();
            _enemyAnimation.SetBoolAttackAnimation(_canAttack);
        }


    }

}

