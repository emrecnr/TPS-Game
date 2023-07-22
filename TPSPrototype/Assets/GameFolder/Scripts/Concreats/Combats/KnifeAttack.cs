using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.ScriptableObjects;
using UnityEngine;

namespace TPSPrototype.Combats
{
    public class KnifeAttack : IAttackType
    {
        Transform _knifeObjectTransform;
        AttackSO _attackSo;

        public KnifeAttack(Transform knifeObjectTransform,AttackSO attackSO)
        {
               _attackSo = attackSO;
                _knifeObjectTransform = knifeObjectTransform;
        }

        public void Attack()
        {
            Vector3 attackPoint = _knifeObjectTransform.position;
            Collider[] colliders = Physics.OverlapSphere(attackPoint,_attackSo.Distance,_attackSo.Layer);
            
            foreach (Collider collider in colliders)
            {
                Debug.Log(colliders[0].name);

                if (collider.TryGetComponent(out IHealth health)) 
                {
                    health.TakeDamage(5);
                }
            }
        }
    }
}

