using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public abstract class SkillStrategy : ScriptableObject
    {
        public abstract void UseSkill(Transform targetPosition);
    }
}
