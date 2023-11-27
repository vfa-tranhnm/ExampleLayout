namespace BugBoxGames.EnhancedEffect
{
    using UnityEngine;
    using DG.Tweening;

    [DisallowMultipleComponent]
    public class EnhancedEffectRotateShow : BaseEffect
    {
        [SerializeField] private Vector3 _fromValue = new Vector3(0, 0, 180);
        [SerializeField] private Vector3 _toValue;

        public void SetFromValue(Vector3 fromValue)
        {
            _fromValue = fromValue;
        }

        protected override Tween OnShowEffect()
        {
            transform.localRotation = Quaternion.Euler(_fromValue);
            return transform.DORotate(_toValue, _showTime);
        }

        protected override Tween OnHideEffect()
        {
            return transform.DORotate(_fromValue, _hideTime);
        }

        private void OnValidate()
        {
            _toValue = transform.localEulerAngles;
        }
    }
}