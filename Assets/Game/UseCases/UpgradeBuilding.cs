using Domain.Gameplay.Models;

namespace Game.UseCases
{
    public class UpgradeBuilding
    {
        private Map _map;

        public UpgradeBuilding(Map map)
        {
            _map = map;
        }
    }
}