using Scripts.Application.UseCases;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Scripts.Presentation
{
    public class RandomTextContainerView : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private RandomTextContainerUpdateTextUseCase _useCase;

        [Inject]
        public void Construct(RandomTextContainerUpdateTextUseCase someUseCase)
        {
            _useCase = someUseCase;
        }

        private void Awake()
        {
            _button.onClick.AddListener(OnClickHandler);
        }

        private void OnClickHandler()
        {
            string newValue = _useCase.Execute();
            Debug.Log($"New value: {newValue}");
        }
    }
}