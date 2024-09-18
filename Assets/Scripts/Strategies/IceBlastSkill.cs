using UnityEngine;

namespace StrategyPattern
{
    [CreateAssetMenu(fileName = "IceBlastMagic", menuName = "Magic/IceBlast")]
    public class IceBlastSkill: SkillStrategy
    {
        [SerializeField]
        private GameObject _iceBlastPrefab;
        
        [SerializeField]
        public float _freezeDuration;
        
        public override void UseSkill(Transform targetPosition)
        {
            Vector3 skillSpawnPosition = targetPosition.position;
            skillSpawnPosition.y += 2f;
            var iceBlast = Instantiate(_iceBlastPrefab, skillSpawnPosition, Quaternion.identity, targetPosition);
            Destroy(iceBlast, _freezeDuration);
        }
    }
}