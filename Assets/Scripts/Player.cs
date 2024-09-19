using System;
using StrategyPattern;
using UnityEngine;
using UnityEngine.Serialization;

namespace StrategyPattern
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        SkillStrategy[] _skilltrategies;
        
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
            _skilltrategies[index].UseSkill(transform);
        }
    }
}