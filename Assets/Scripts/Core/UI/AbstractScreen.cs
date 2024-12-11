using System;
using UnityEngine;

namespace CORE.UI
{
    public abstract class AbstractScreen : MonoBehaviour
    {
        [SerializeField] 
        private CanvasGroup _canvasGroup;

        private void Awake()
        {
            HideInstantly();
        }

        public void ShowInstantly()
        {
            SetCanvasActivity(true);
        }

        public void HideInstantly()
        {
            SetCanvasActivity(false);
        }

        private void SetCanvasActivity(bool isActive)
        {
            _canvasGroup.alpha = isActive? 1f : 0f;
            _canvasGroup.blocksRaycasts = isActive;
            _canvasGroup.interactable = isActive;
        }
    }
}