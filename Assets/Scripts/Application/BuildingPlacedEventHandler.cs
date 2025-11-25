using Scripts.Application;
using UnityEngine;

namespace Scripts.Infrastructure.Gameplay
{
    public class BuildingPlacedEventHandler : IBuildingPlacedEvent
    {
        private readonly GameObject _prefab;

        public BuildingPlacedEventHandler(GameObject prefab)
        {
            _prefab = prefab;
        }

        public void OnBuildingPlaced(int x, int y)
        {
            Object.Instantiate(_prefab, new Vector3(x, 0, y), Quaternion.identity);
        }
    }
}