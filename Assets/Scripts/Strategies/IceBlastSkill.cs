using UnityEngine;

namespace StrategyPattern
{
    [CreateAssetMenu(fileName = "IceBlastSkill", menuName = "Skill/IceBlast")]
    public class IceBlastSkill: SkillStrategy
    {
        [SerializeField]
        private GameObject _iceBlastPrefab;
        
        [SerializeField]
        public float _destroyTime=5f;
        
        public override void UseSkill(Transform targetPosition)
        {
            Vector3 skillSpawnPosition = targetPosition.position;
            skillSpawnPosition.y += .2f;
            var iceBlast = Instantiate(_iceBlastPrefab, skillSpawnPosition, Quaternion.identity, targetPosition);
            
            var objectDestructor= iceBlast.AddComponent<ObjectDestructor>();
            objectDestructor.Initialize(_destroyTime);
        }
    }
}