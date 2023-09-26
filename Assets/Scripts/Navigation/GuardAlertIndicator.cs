using System;
using UnityEngine;

namespace Navigation
{
    public class GuardAlertIndicator : MonoBehaviour
    {
        private SecurityPatrol _patrol;
        private bool _active = true;
        private void Awake()
        {
            //getcomponentinparent searches self and all parents until finds one.
            _patrol = GetComponentInParent<SecurityPatrol>();
            if (_patrol == null)
            {
                Debug.LogError("Alert must be a child of SecurityPatrol! put this a a child object. Deleting.");
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if (_patrol.patrolState == SecurityPatrol.PatrolState.ChasePlayer)
            {
                if (!_active)
                {
                    SetChildrenActive(true);
                }
            }
            else
            {
                if (_active)
                {
                    SetChildrenActive(false);  
                }
                
            }
        }

        private void SetChildrenActive(bool isActive)
        {
            _active = isActive;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(isActive);
            }
        }
    }
}