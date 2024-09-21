using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// A skill that spawns a shield around the target and destroys it after a certain duration.
    /// </summary>
    [CreateAssetMenu(fileName = "ShieldSkill", menuName = "Skill/Shield")]
    public class ShieldSkill : SkillStrategy
    {
        [Tooltip("The prefab for the shield object.")]
        [SerializeField]
        private GameObject _shieldPrefab;

        [Tooltip("Time after which the shield will be destroyed.")]
        [SerializeField]
        public float _destroyTime = 3f;

        [Tooltip("The Y-axis offset for the shield's spawn position.")]
        [SerializeField]
        private float _yOffset = 1.25f;

        public override void UseSkill(Transform targetPosition, Animator animator)
        {
            if (_shieldPrefab == null)
            {
                Debug.LogError("Shield prefab is not assigned!");
                return;
            }

            TriggerAnimation(animator);

            var targetVector = targetPosition.position;
            targetVector.y += _yOffset;

            var shieldSkill = SpawnSkill(_shieldPrefab, targetVector, targetPosition);

            AddDestructor(shieldSkill, _destroyTime);
        }
    }
}