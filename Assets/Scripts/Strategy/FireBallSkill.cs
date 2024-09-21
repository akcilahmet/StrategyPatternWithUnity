using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// A FireBall skill that spawns a fireball projectile and moves it forward with a given speed and duration.
    /// </summary>
    [CreateAssetMenu(fileName = "FireBallSkill", menuName = "Skill/FireBall")]
    public class FireBallSkill : SkillStrategy
    {
        [Tooltip("The prefab for the fireball projectile.")]
        [SerializeField]
        private GameObject _fireBallPrefab;

        [Tooltip("The movement speed of the fireball.")]
        [SerializeField]
        private float _moveSpeed = 10f;

        [Tooltip("Time after which the fireball will be destroyed.")]
        [SerializeField]
        private float _destroyTime = 5f;

        [Tooltip("The offset for the fireball's Y-axis position when spawned.")]
        [SerializeField]
        private float _yOffset = 1.25f;

        public override void UseSkill(Transform targetPosition, Animator animator)
        {
            if (_fireBallPrefab == null)
            {
                Debug.LogError("Fireball prefab is not assigned!");
                return;
            }

            TriggerAnimation(animator);

            var targetVector = targetPosition.position + (targetPosition.forward * _yOffset);
            targetVector.y += _yOffset;

            var fireBall = SpawnSkill(_fireBallPrefab, targetVector, targetPosition);

            var projectileMovement = fireBall.AddComponent<ProjectileMovement>();
            projectileMovement.Initialize(targetPosition.forward, _moveSpeed);

            AddDestructor(fireBall, _destroyTime);
        }
    }
}