using Scripts.Application.UseCases;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Scripts.Domain.Gameplay.Models
{
    public class SpawnPrefabButtonView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        private PlaceBuilding _placeBuildingUseCase;

        [Inject]
        public void Construct(PlaceBuilding placeBuildingUseCase)
        {
            _placeBuildingUseCase = placeBuildingUseCase;
        }

        private void Awake()
        {
            _button.onClick.AddListener(OnClickHandler);
        }

        private void OnClickHandler()
        {
            _placeBuildingUseCase.Execute(5, 5, new Building());
        }
    }
}