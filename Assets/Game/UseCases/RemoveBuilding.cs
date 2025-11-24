using Domain.Gameplay.Models;

namespace Game.UseCases
{
    public class RemoveBuilding
    {
        private Map _map;

        public RemoveBuilding(Map map)
        {
            _map = map;
        }
    }
}