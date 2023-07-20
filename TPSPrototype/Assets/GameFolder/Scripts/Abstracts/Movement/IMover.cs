using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TPSPrototype.Abstracts.Movements 
{
    public interface IMover 
    {
        void MoveAction(Vector3 direction);
        float MoveSpeed { get; }



    }
}


