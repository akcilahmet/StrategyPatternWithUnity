using UnityEngine;

namespace StrategyPattern
{
    public class ProjectileMovement: MonoBehaviour
    {
        private float _moveSpeed;
        private Vector3 _direction;
        private bool _isInitialized = false;

        public void Initialize(Vector3 direction, float moveSpeed)
        {
            _moveSpeed = moveSpeed;
            _direction = direction.normalized;
            _isInitialized = true; // Hareketi başlatmak için flag ayarlanır
        }
        
        private void Update()
        {
            if (_isInitialized)
            {
                transform.Translate(_direction * _moveSpeed * Time.deltaTime, Space.World);
            }
        }
    }
}