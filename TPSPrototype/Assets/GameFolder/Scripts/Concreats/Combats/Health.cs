using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.ScriptableObjects;
using UnityEngine;

namespace TPSPrototype.Combats 
{
    public class Health : MonoBehaviour, IHealth
    {
        
        public bool IsDead => currentHealth <= 0;

        int currentHealth;

        [SerializeField] HealthSO _healthInfo;

        private void Awake()
        {
            currentHealth = _healthInfo.Maxhealth;
        }
        public void TakeDamage(int damageAmount)
        {
            if (IsDead) return;
            currentHealth -= damageAmount;
            Debug.Log(IsDead);
        }
    }
}

