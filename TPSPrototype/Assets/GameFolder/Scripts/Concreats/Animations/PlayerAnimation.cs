using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Controllers;
using UnityEngine;

namespace TPSPrototype.Animations
{
    public class PlayerAnimation 
    {
        Animator _playerAnimator;
        
        public PlayerAnimation(PlayerController playerController)
        {
            _playerAnimator = playerController.GetComponentInChildren<Animator>();
        }

        public void SetMoveAnimation(float moveSpeed)
        {
            _playerAnimator.SetFloat("moveSpeed", moveSpeed);
        }
    }
}

