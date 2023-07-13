using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Inputs;
using TPSPrototype.Abstracts.Movements;
using TPSPrototype.Movements;
using UnityEngine;


namespace TPSPrototype.Controllers
{

    public class PlayerController : MonoBehaviour
    {
        IInput _input;
        IMover _mover;

        float _moveSpeed=5f;
        private void Awake()
        {
            _input = GetComponent<IInput>();
            _mover = new CharacterControllerMover(this, _moveSpeed);

        }

        private void Update()
        {
            Debug.Log(_input.MoveDirection);
            _mover.MoveAction(_input.MoveDirection);
        }

    }


}
