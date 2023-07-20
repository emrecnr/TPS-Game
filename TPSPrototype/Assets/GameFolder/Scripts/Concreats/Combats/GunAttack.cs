using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.ScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;

namespace TPSPrototype.Combats
{
    public class GunAttack : IAttackType
    {
        Camera _camera;
        float _distance;
        LayerMask _layerMask;
        public GunAttack(AttackSO attackSO,Transform camera)
        {
            _camera = camera.GetComponent<Camera>();
            _distance = attackSO.Distance;
            _layerMask = attackSO.Layer;
        }

        public void Attack()
        {
            Ray ray = _camera.ViewportPointToRay(Vector3.one / 2f);
            if (Physics.Raycast(ray, out RaycastHit hit, _distance, _layerMask))
            {

                IHealth health = hit.collider.GetComponent<IHealth>();
                if (health != null)
                {
                    health.TakeDamage(10);
                }

            }
        }
    }
}

