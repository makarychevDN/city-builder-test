using Domain.Gameplay.Models;

namespace Game.UseCases
{
    public class PlaceBuilding
    {
        private Map _map;

        public PlaceBuilding(Map map)
        {
            _map = map;
        }
    }
}