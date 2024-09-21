using System;
using UnityEngine;
using UnityEngine.UI;

namespace StrategyPattern
{
    /// <summary>
    /// Manages the UI for triggering skill usage by the player. Each button in the UI corresponds to a specific skill.
    /// </summary>
    public class SkillUI : MonoBehaviour
    {
        [Tooltip(
            "An array of buttons representing different skills. Each button triggers a specific skill when clicked.")]
        [SerializeField]
        private Button[] _buttons;

        /// <summary>
        /// Event invoked when a button is pressed, sending the index of the button to trigger the appropriate skill.
        /// </summary>
        public static event Action<int> ButtonPressed;

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