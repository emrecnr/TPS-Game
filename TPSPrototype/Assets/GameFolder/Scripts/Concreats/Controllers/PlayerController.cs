using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Controllers;
using TPSPrototype.Abstracts.Inputs;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Animations;
using TPSPrototype.Movements;
using UnityEngine;


namespace TPSPrototype.Controllers
{

    public class PlayerController : MonoBehaviour, IEntityController
    {
        IInput _input;
        IMover _mover;
        IRotator _xRotation;
        IRotator _yRotation;

        PlayerAnimation _playerAnimation;
        Vector3 _moveDirection;
        float _moveSpeed=5f;

        [SerializeField] Transform cameraTransform;
        public Transform CameraTransform => cameraTransform;

        public Transform Controller => transform;

        

        [SerializeField] WeaponController _currentWeapon;

        private void Awake()
        {
            _input = GetComponent<IInput>();
            _mover = new CharacterControllerMover(this, _moveSpeed);
            _playerAnimation = new PlayerAnimation(this);
            _xRotation = new RotationX(this);
            _yRotation = new RotationY(this);

        }

        private void Update()
        {
            _xRotation.RotateAction(_input.Rotation.x);
            _yRotation.RotateAction(_input.Rotation.y);
            _moveDirection = _input.MoveDirection;
            if (_input.CanFire)
            {
                _currentWeapon.Fire();
            }
            
            
            
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
