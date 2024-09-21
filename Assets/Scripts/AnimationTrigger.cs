using UnityEngine;

namespace StrategyPattern
{
    [CreateAssetMenu(fileName = "NewAnimationTrigger", menuName = "Animation/AnimationTrigger")]
    public class AnimationTrigger : ScriptableObject
    {
        [Tooltip("The name of the animation trigger in the Animator.")]
        [SerializeField]
        private string _triggerName;

        /// <summary>
        /// Gets the name of the animation trigger.
        /// </summary>
        public string TriggerName => _triggerName;
    }
}