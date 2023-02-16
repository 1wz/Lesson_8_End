using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui.MainMenu
{
    internal class BackToMenuView : MonoBehaviour
    {
        [SerializeField] private Button _backToMenuButton;

        public void Init(UnityAction backToMenu) =>
            _backToMenuButton.onClick.AddListener(backToMenu);

        private void OnDestroy() =>
            _backToMenuButton.onClick.RemoveAllListeners();
    }
}
