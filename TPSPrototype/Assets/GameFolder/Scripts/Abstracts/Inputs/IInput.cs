using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.Abstracts.Inputs
{
    public interface  IInput 
    {
         Vector3 MoveDirection { get;  }
         Vector2 Rotation { get; }
        bool CanFire { get; }
        bool IsChangeWeapon { get; }


    }


}

