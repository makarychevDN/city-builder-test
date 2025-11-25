using UnityEngine;

namespace Scripts.Infrastructure.Gameplay
{
    public class BuildingSpawner : IBuildingSpawner
    {
        private readonly GameObject _prefab;

        public BuildingSpawner(GameObject prefab)
        {
            _prefab = prefab;
        }

        public void SpawnBuilding(int x, int y)
        {
            Vector3 position = new Vector3(x, 0, y);
            Object.Instantiate(_prefab, position, Quaternion.identity);
        }
    }
}