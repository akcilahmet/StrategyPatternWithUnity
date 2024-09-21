using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// Abstract base class for implementing skill strategies in the Strategy Pattern.
    /// </summary>
    public abstract class SkillStrategy : ScriptableObject
    {
        [Tooltip("Cooldown time for the skill in seconds.")]
        [SerializeField]
        private float _cooldownTime = 1f;

        [Tooltip("The animation trigger for this skill.")]
        [SerializeField]
        protected AnimationTrigger  _animationTrigger;

        /// <summary>
        /// Triggers the skill animation using the Animator.
        /// </summary>
        protected void TriggerAnimation(Animator animator)
        {
            animator.SetTrigger(_animationTrigger.TriggerName); // Enum yerine ScriptableObject'ten gelen tetikleyici ismi
        }
        
        /// <summary>
        /// Spawns a skill object (e.g., a projectile) at the specified position with an optional parent transform.
        /// </summary>
        protected GameObject SpawnSkill(GameObject prefab, Vector3 targetPosition, Transform parent = null)
        {
            return Instantiate(prefab, targetPosition, Quaternion.identity, parent);
        }

        /// <summary>
        /// Adds a destructor component to the skill object to automatically destroy it after a specified time.
        /// </summary>
        protected void AddDestructor(GameObject skillObject, float destroyTime)
        {
            var objectDestructor = skillObject.AddComponent<ObjectDestructor>();
            objectDestructor.Initialize(destroyTime);
        }

        /// <summary>
        /// Abstract method for using a skill, to be implemented by subclasses.
        /// </summary>
        public abstract void UseSkill(Transform targetPosition, Animator animator);

        /// <summary>
        /// Gets the cooldown time for the skill in seconds.
        /// </summary>
        public float CooldownTime => _cooldownTime;
    }
}