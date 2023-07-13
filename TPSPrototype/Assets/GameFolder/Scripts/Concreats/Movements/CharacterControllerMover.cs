using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Controllers;
using UnityEngine;


namespace TPSPrototype.Movements
{
    public class CharacterControllerMover : IMover
    {
        CharacterController _characterController;
        float _moveSpeed;


        public CharacterControllerMover(PlayerController playerController, float moveSpeed)
        {
            _characterController = playerController.GetComponent<CharacterController>();
            _moveSpeed = moveSpeed;
        }
        public void MoveAction(Vector3 direction)
        {
            if (direction == Vector3.zero) { return; }


            Vector3 position = _characterController.transform.TransformDirection(direction);
            Vector3 moveDirection = position*_moveSpeed*Time.deltaTime;

            _characterController.Move(moveDirection);
        }
    }
}

