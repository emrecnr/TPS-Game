using System.Collections;
using System.Collections.Generic;
using TPSPrototype.ScriptableObjects;
using UnityEngine;

namespace TPSPrototype.GizmosHelper
{
    public class KnifeAttackRangeGizmos : MonoBehaviour
    {
        [SerializeField] AttackSO _attackSO;

        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(transform.position, _attackSO.Distance);
        }
    }

}
