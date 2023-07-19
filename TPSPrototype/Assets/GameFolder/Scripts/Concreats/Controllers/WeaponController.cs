
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSPrototype.Controllers
{
   
    public class WeaponController : MonoBehaviour
    {

        
        [SerializeField]bool _canFire;
        [SerializeField] float _attackDelay = 0.2f;
        [SerializeField] float _distance = 300f;
        [SerializeField] Camera _camera;
        [SerializeField] LayerMask _layerMask;
        float _currentTime = 0f;
        private void Update()
        {
            _currentTime += Time.deltaTime;
            _canFire = _currentTime > _attackDelay;
           
        }
        public void Fire()
        {
            if (!_canFire) { return; }

            Ray ray = _camera.ViewportPointToRay(Vector3.one / 2f);
            if (Physics.Raycast(ray,out RaycastHit hit,_distance,_layerMask))
            {
                Debug.Log(hit.collider.gameObject.name);
               
            }
            
            _currentTime = 0f;  
        }
        


    }


}

