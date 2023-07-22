using System;
using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using UnityEngine;

namespace TPSPrototype.States
{
    public class StateTransformer
    {
       public IState To { get;}
       public  IState From { get; }
       public System.Func<bool> Condition{get;}

        public StateTransformer(IState from, IState to, Func<bool> condition)
        {
            To = to;
            From = from;
            Condition = condition;
        }
    }
}

