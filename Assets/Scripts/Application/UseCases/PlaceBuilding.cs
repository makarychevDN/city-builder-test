using Scripts.Domain.Gameplay.Models;
using Scripts.Application;

namespace Scripts.Application.UseCases
{
    public class PlaceBuilding
    {
        private Map _map;
        private readonly IBuildingPlacedEvent _event;

        public PlaceBuilding(Map map, IBuildingPlacedEvent buildingPlacedEvent)
        {
            _map = map;
            _event = buildingPlacedEvent;
        }

        public void Execute(int xPos, int yPos, Building building)
        {
            if (!_map.CellIsEmpty(xPos, yPos))
                return;

            _map.PlaceBuilding(yPos, xPos, building);
            _event.OnBuildingPlaced(xPos, yPos);
        }
    }
}