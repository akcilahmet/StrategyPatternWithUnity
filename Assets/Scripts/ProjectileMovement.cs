using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// Controls the movement of a projectile in a specified direction with a given speed.
    /// </summary>
    public class ProjectileMovement : MonoBehaviour
    {
        private float _moveSpeed;
        private Vector3 _direction;
        private bool _isInitialized = false;

        /// <summary>
        /// Initializes the projectile movement with a specified direction and speed.
        /// </summary>
        public void Initialize(Vector3 direction, float moveSpeed)
        {
            _moveSpeed = moveSpeed;
            _direction = direction.normalized;
            _isInitialized = true;
        }

        private void Update()
        {
            if (_isInitialized)
            {
                transform.Translate(_direction * (Time.deltaTime * _moveSpeed), Space.World);
            }
        }
    }
}