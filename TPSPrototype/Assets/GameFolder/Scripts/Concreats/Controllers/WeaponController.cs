
using System.Collections;
using System.Collections.Generic;
using TPSPrototype.Abstracts.Combats;
using TPSPrototype.Combats;
using TPSPrototype.ScriptableObjects;
using UnityEngine;

namespace TPSPrototype.Controllers
{
   
    public class WeaponController : MonoBehaviour
    {

        
        [SerializeField]bool _canFire;
        
        [SerializeField] Transform _cameraTransform;
        [SerializeField] AttackSO _attackSO;
        public AttackSO AttackSO => _attackSO;

        float _currentTime = 0f;
        IAttackType _attackType;

        private void Awake()
        {
            _attackType = _attackSO.GetAttackType(_cameraTransform);
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            _canFire = _currentTime > _attackSO.AttackDelay;
           
        }
        public void Fire()
        {
            
            if (!_canFire) { return; }
            _currentTime = 0f;
            _attackType.Attack();
            
             
        }
        


    }


}

