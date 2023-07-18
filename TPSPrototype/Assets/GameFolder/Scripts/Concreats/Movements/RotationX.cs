using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Controllers;
using UnityEngine;

public class RotationX : IRotator
{
    PlayerController _playerController;

    float _rotationSpeed = 40f;

    public RotationX(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void RotateAction(float direction)
    {
        _playerController.transform.Rotate(Vector3.up * direction *_rotationSpeed*Time.deltaTime);
       // _playerController.GetComponentInChildren<Transform>().transform.Rotate(Vector3.up * direction * _rotationSpeed * Time.deltaTime);
    }


}
