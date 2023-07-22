using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TPSPrototype.Combats;

namespace TPSPrototype.UI 
{
    public class UIHealth : MonoBehaviour
    {
        TextMeshProUGUI _healthText;

        private void Awake()
        {
            _healthText = GetComponentInChildren<TextMeshProUGUI>();
        }
        private void OnEnable()
        {
            Health health = GetComponentInParent<Health>();
            health.OnHealthChange += HandleHealthChange;
        }
        private void OnDisable()
        {
            Health health = GetComponentInParent<Health>();
            health.OnHealthChange -= HandleHealthChange;
        }

        void HandleHealthChange(int currentHealth)
        {
            _healthText.text = currentHealth.ToString();
        }
    }
}

