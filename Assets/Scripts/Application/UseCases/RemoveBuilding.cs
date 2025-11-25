using Scripts.Domain.Gameplay.Models;

namespace Scripts.Application.UseCases
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