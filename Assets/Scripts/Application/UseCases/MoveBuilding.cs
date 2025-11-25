using Scripts.Domain.Gameplay.Models;

namespace Scripts.Application.UseCases
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