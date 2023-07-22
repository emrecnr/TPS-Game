using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.Abstracts.Controllers;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Animations;
using TPSPrototype.Combats;
using TPSPrototype.EnemyStates;
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
        StateMachine _stateMachine;
        bool _canAttack;
        public bool CanAttack => Vector3.Distance(transform.position, _playerPref.transform.position) <= _navMeshAgent.stoppingDistance;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _mover = new NavMeshMover(this);
            _enemyAnimation = new EnemyAnimation(this);
            _health = GetComponent<IHealth>();
            _equipController = GetComponent<EquipController>();
            _stateMachine = new StateMachine();

        }
        private void Start()
        {
            AttackState attackState = new AttackState();
            ChaseState chaseState = new ChaseState();
            DeadState deadState = new DeadState();
            _stateMachine.AddState(chaseState,attackState,()=>CanAttack);
            _stateMachine.AddState(attackState, chaseState, () => !CanAttack);
            _stateMachine.AddAnyState(deadState,() => _health.IsDead);
            _stateMachine.SetState(chaseState);
        }
        private void Update()
        {
            if (_health.IsDead) { return; }
            _mover.MoveAction(_playerPref.transform.position);

            
            _stateMachine.Tick();
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

