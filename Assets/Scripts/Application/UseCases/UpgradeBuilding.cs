using Scripts.Domain.Gameplay.Models;

namespace Scripts.Application.UseCases
{
    public class UpgradeBuilding
    {
        private Map _map;

        public UpgradeBuilding(Map map)
        {
            _map = map;
        }

        public void Execute(Building building)
        {
            building?.Upgrade();
        }
    }
}