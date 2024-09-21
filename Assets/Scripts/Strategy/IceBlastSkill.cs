using System.Collections;
using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// A skill that spawns an Ice Blast projectile 
    /// </summary>
    [CreateAssetMenu(fileName = "IceBlastSkill", menuName = "Skill/IceBlast")]
    public class IceBlastSkill : SkillStrategy
    {
        [Tooltip("The prefab for the Ice Blast projectile.")]
        [SerializeField]
        private GameObject _iceBlastPrefab;

        [Tooltip("Time after which the Ice Blast will be destroyed.")]
        [SerializeField]
        public float _destroyTime = 5f;

        [Tooltip("The Y-axis offset for the Ice Blast's spawn position.")]
        [SerializeField]
        private float _yOffset = 0.2f;

        [Tooltip("The Z-axis offset for the Ice Blast's spawn position.")]
        [SerializeField]
        private float _zOffset = 1.2f;

        public override void UseSkill(Transform targetPosition, Animator animator)
        {
            if (_iceBlastPrefab == null)
            {
                Debug.LogError("IceBlast prefab is not assigned!");
                return;
            }

            TriggerAnimation(animator);

            var targetVector = targetPosition.position + (targetPosition.forward * _zOffset);
            targetVector.y += _yOffset;

            var iceBlast = SpawnSkill(_iceBlastPrefab, targetVector, targetPosition);

            AddDestructor(iceBlast, _destroyTime);
        }
    }
}