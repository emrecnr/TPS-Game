using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.ScriptableObjects
{
    [CreateAssetMenu(fileName ="Attack",menuName = "AttackInfo/Create New",order =51)]
    public class AttackSO : ScriptableObject
    {
        [SerializeField] float _distance = 100f;
        [SerializeField] float _attackDelay = 0.2f;
        [SerializeField] LayerMask _layerMask;
        public float Distance => _distance;
        public float AttackDelay => _attackDelay;
        public LayerMask Layer => _layerMask;
    }
}

