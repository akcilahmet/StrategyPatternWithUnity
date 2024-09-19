using UnityEngine;

namespace StrategyPattern
{
    [CreateAssetMenu(fileName = "FireBallSkill", menuName = "Skill/FireBall")]
    public class FireBallSkill: SkillStrategy
    {
        [SerializeField]
        private GameObject _fireBallPrefab;

        [SerializeField]
        private float _moveSpeed = 10f;
        
        [SerializeField]
        public float _destroyTime = 5f;
        public override void UseSkill(Transform targetPosition)
        {
            Vector3 skillSpawnPosition = targetPosition.position;
            skillSpawnPosition.y += 1.25f;
            var fireBall = Instantiate(_fireBallPrefab, skillSpawnPosition, Quaternion.identity, targetPosition);

            var projectileMovement = fireBall.AddComponent<ProjectileMovement>();
            projectileMovement.Initialize(targetPosition.forward, _moveSpeed);
            
            var objectDestructor= fireBall.AddComponent<ObjectDestructor>();
            objectDestructor.Initialize(_destroyTime);
        }
    }
    
}