using UnityEngine;
using UnityEngine.Serialization;

namespace StrategyPattern
{
    [CreateAssetMenu(fileName = "ShieldSkill", menuName = "Skill/Shield")]
    public class ShieldSkill: SkillStrategy
    {
        [SerializeField]
        private GameObject _shieldPrefab;
        
        [SerializeField]
        public float _destroyTime = 3f;
        public override void UseSkill(Transform targetPosition)
        {
            Vector3 skillSpawnPosition = targetPosition.position;
            skillSpawnPosition.y += 1.25f;
            var shieldSkill = Instantiate(_shieldPrefab, skillSpawnPosition, Quaternion.identity, targetPosition);
            
            var objectDestructor= shieldSkill.AddComponent<ObjectDestructor>();
            objectDestructor.Initialize(_destroyTime);
        }
    }
}