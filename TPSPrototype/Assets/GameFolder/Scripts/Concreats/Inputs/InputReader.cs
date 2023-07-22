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
        int _index;
        public Vector3 MoveDirection { get; private set; }

        public Vector2 Rotation { get; private set; }
        public bool CanFire { get; private set; }

        public bool IsChangeWeapon { get; private set; }

        public void OnRotation(InputAction.CallbackContext context)
        {
            Rotation = context.ReadValue<Vector2>();

        }
        public void Move(InputAction.CallbackContext context)
        {
           Vector2 direction = context.ReadValue<Vector2>();

            MoveDirection = new Vector3(direction.x,0f,direction.y);
        }
        
        public void OnFire(InputAction.CallbackContext context)
        {
            CanFire = context.ReadValueAsButton();
            Debug.Log(CanFire);
        }
        public void OnChangeWeapon(InputAction.CallbackContext context)
        {
            if (IsChangeWeapon && context.action.triggered)
            {
                return;
            }
            StartCoroutine(WaitOnFrame());
            IsChangeWeapon = context.ReadValueAsButton();
        }
        IEnumerator WaitOnFrame()
        {
            IsChangeWeapon = true && _index % 2 == 0;
            yield return new WaitForEndOfFrame();
            IsChangeWeapon = false;
        }

        
    }





}

