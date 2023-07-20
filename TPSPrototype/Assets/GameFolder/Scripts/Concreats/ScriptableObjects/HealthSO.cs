using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.ScriptableObjects
{
    [CreateAssetMenu(fileName ="Health",menuName ="HealthInfo/Create New",order =51)]
    public class HealthSO : ScriptableObject
    {
        [SerializeField] int _maxHealth;
        public int Maxhealth => _maxHealth;
    }
}

