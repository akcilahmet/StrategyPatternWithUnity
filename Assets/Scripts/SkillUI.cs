
using System;
using UnityEngine;
using UnityEngine.UI;

namespace StrategyPattern
{
    public class SkillUI: MonoBehaviour
    {
        [SerializeField]
        private Button[] _buttons;
        
        public static event Action<int>  ButtonPressed;

        private void Awake()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                var index = i;
                _buttons[i].onClick.AddListener(() => OnButtonPressed(index));
            }
        }

        private void OnButtonPressed(int index)
        {
            ButtonPressed?.Invoke(index);
        }
    }
}