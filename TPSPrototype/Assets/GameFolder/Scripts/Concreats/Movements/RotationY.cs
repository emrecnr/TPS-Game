using System.Collections;
using System.Collections.Generic;
using TMPro;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Controllers;
using UnityEngine;

namespace TPSPrototype.Movements
{
    public class RotationY : IRotator
    {
        
        Transform _camTransform;
        float _tilt;
        float moveSpeed = 50f;
        public RotationY(PlayerController playerController)
        {
            _camTransform = playerController.CameraTransform;
        }
        public void RotateAction(float direction)
        {
           direction*= moveSpeed*Time.deltaTime;
            _tilt = Mathf.Clamp(_tilt-direction, -30f,30);
            _camTransform.localRotation = Quaternion.Euler(_tilt,0f,0f);
        }
    }
}

