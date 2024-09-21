using System.Collections;
using UnityEngine;

namespace StrategyPattern
{
    /// <summary>
    /// The Player class is responsible for managing skill usage and handling input from the UI.
    /// It triggers animations and executes the appropriate skill based on the player's input.
    /// </summary>
    public class Player : MonoBehaviour
    {
        private Animator _animator;
        private bool[] _isOnCooldown;

        [Tooltip("An array of skill strategies available to the player.")]
        [SerializeField]
        private SkillStrategy[] _skillStrategies;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _isOnCooldown = new bool[_skillStrategies.Length];
        }

        private void OnEnable()
        {
            SkillUI.ButtonPressed += UseSkill;
        }

        private void OnDisable()
        {
            SkillUI.ButtonPressed -= UseSkill;
        }

        private void UseSkill(int index)
        {
            if (_isOnCooldown[index])
            {
                return;
            }

            _skillStrategies[index].UseSkill(transform, _animator);
            StartCoroutine(CooldownRoutine(index, _skillStrategies[index].CooldownTime));
        }

        private IEnumerator CooldownRoutine(int index, float cooldownTime)
        {
            _isOnCooldown[index] = true;
            yield return new WaitForSeconds(cooldownTime);
            _isOnCooldown[index] = false;
        }
    }
}