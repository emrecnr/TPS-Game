using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.Abstracts.Combats 
{
    public interface IHealth
    {
        bool IsDead { get;  }
        void TakeDamage(int damageAmount);



    }

}

