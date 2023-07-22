using System;
using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using UnityEngine;

namespace TPSPrototype.States
{
    public class StateTransformer
    {
        IState To { get;}
        IState From { get; }
        System.Func<bool> Condition{get;}

        public StateTransformer(IState to, IState from, Func<bool> condition)
        {
            To = to;
            From = from;
            Condition = condition;
        }
    }
}

