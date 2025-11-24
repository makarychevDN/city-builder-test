using Domain.Gameplay.Models;

namespace Game.UseCases
{
    public class MoveBuilding
    {
        private Map _map;

        public MoveBuilding(Map map)
        {
            _map = map;
        }
    }
}