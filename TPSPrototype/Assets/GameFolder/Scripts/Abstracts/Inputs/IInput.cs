using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.Abstracts.Inputs
{
    public interface  IInput 
    {
        public Vector3 MoveDirection { get;  }
        public Vector2 Rotation { get; }
        public bool CanFire { get; }


    }


}

