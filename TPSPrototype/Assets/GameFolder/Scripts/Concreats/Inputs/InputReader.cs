using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Inputs;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TPSPrototype.Inputs
{
    public class InputReader : MonoBehaviour, IInput
    {
        public Vector3 MoveDirection { get; private set; }

        public void Move(InputAction.CallbackContext context)
        {
           Vector2 direction = context.ReadValue<Vector2>();

            MoveDirection = new Vector3(direction.x,0f,direction.y);
        }
    }





}

