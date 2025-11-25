using Scripts.Domain.Gameplay.Models;

namespace Scripts.Application.UseCases
{
    public class PlaceBuilding
    {
        private Map _map;

        public PlaceBuilding(Map map)
        {
            _map = map;
        }

        public void Execute(int xPos, int yPos)
        {
            if (!_map.CellIsEmpty(xPos, yPos))
                return;
        }
    }
}