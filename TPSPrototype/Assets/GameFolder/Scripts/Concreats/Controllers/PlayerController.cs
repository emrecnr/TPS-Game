using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Inputs;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Animations;
using TPSPrototype.Movements;
using UnityEngine;


namespace TPSPrototype.Controllers
{

    public class PlayerController : MonoBehaviour
    {
        IInput _input;
        IMover _mover;
        PlayerAnimation _playerAnimation;
        Vector3 _moveDirection;
        float _moveSpeed=5f;
        private void Awake()
        {
            _input = GetComponent<IInput>();
            _mover = new CharacterControllerMover(this, _moveSpeed);
            _playerAnimation = new PlayerAnimation(this);

        }

        private void Update()
        {
            _moveDirection = _input.MoveDirection;
            
        }
        private void FixedUpdate()
        {
            _mover.MoveAction(_moveDirection);
        }
        private void LateUpdate()
        {
            _playerAnimation.SetMoveAnimation(_moveDirection.magnitude);
        }

    }


}
