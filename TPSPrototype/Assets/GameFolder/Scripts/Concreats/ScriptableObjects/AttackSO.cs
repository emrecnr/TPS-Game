using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.Combats;
using UnityEngine;

namespace TPSPrototype.ScriptableObjects
{
    enum AttackTypeEnum : byte
    {
        Gun,Knife
    }
    [CreateAssetMenu(fileName ="Attack",menuName = "AttackInfo/Create New",order =51)]
    public class AttackSO : ScriptableObject
    {
        [SerializeField] AttackTypeEnum _attackTypeEnum;
        [SerializeField] float _distance = 100f;
        [SerializeField] float _attackDelay = 0.2f;
        [SerializeField] LayerMask _layerMask;
        [SerializeField] AnimatorOverrideController _animatorOverrideController;
        public float Distance => _distance;
        public float AttackDelay => _attackDelay;
        public LayerMask Layer => _layerMask;
        public AnimatorOverrideController AnimatorOverride => _animatorOverrideController;
        public IAttackType GetAttackType(Transform transform)
        {
            if (_attackTypeEnum == AttackTypeEnum.Gun)
            {
                return new GunAttack(this,transform);
            }
            else
            {
                return new KnifeAttack(transform,this);
            }
        }
    }
}

