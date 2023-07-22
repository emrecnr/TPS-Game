using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.Controllers
{
    public class EquipController : MonoBehaviour
    {
        [SerializeField] WeaponController[] _weapons;
        public WeaponController Equip { get; private set; }
        Animator _animator;
        int _index = 0;
        private void Awake()
        {
            _weapons = GetComponentsInChildren<WeaponController>();

            foreach (WeaponController weapon in _weapons)
            {
                weapon.gameObject.SetActive(false);
            }
            _animator = GetComponentInChildren<Animator>();

        }

        private void Start()
        {
            Equip = _weapons[_index];
            Equip.gameObject.SetActive(true);
        }
        public void ChangeWeapon()
        {
            _index++;
            if (_index>=_weapons.Length)
            {
                _index = 0;

            }
            Equip = _weapons[_index];
            foreach (WeaponController weapon in _weapons)
            {
                if (Equip == weapon)
                {
                    weapon.gameObject.SetActive(true);
                    _animator.runtimeAnimatorController = Equip.AttackSO.AnimatorOverride;
                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }
            }
        }
    }
}

