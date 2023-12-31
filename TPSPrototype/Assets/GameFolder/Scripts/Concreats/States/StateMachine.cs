using System;
using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.States;
using TPSPrototype.EnemyStates;
using TPSPrototype.States;
using UnityEngine;

public class StateMachine 
{
    List<StateTransformer> _stateTransformers = new List<StateTransformer>();
    List<StateTransformer> _anyTransformer = new List<StateTransformer>(); //any state

    IState _currentState;

    public void SetState(IState state)
    {
        if (_currentState == state) return;
        
        _currentState?.OnExit();
        _currentState = state;
        _currentState.OnEnter();
    }


    
    public void Tick()
    {
        StateTransformer stateTransformer = CheckForTransformer();
        if (stateTransformer!=null)
        {
            SetState(stateTransformer.To);
        }
        _currentState.Tick();
    }
    private StateTransformer CheckForTransformer()
    {
        foreach (StateTransformer stateTransformer in _anyTransformer)
        {
            if (stateTransformer.Condition.Invoke())
            {
                return stateTransformer;
            }
        }
        foreach (StateTransformer stateTransformer in _stateTransformers)
        {
            if (stateTransformer.Condition.Invoke() && _currentState == stateTransformer.From) return stateTransformer;
        }
        return null;
    }
    public void AddState(IState from, IState to,System.Func<bool> condition)
    {
        StateTransformer stateTransformer = new StateTransformer(from, to, condition);
        _stateTransformers.Add(stateTransformer);
    }
    public void AddAnyState(IState to,System.Func<bool> condition)
    {
        StateTransformer stateTransformer = new StateTransformer (null,to, condition);
        _anyTransformer.Add(stateTransformer);
    }

    
}
