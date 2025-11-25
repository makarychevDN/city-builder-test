namespace Scripts.Domain.Gameplay.Models
{
    public class Map
    {
        private int _sizeX;
        private int _sizeY;
        private readonly Building[,] _grid;

        public Building[,] Grid => _grid;
        public bool CellIsEmpty(int posX, int posY) => _grid[posX, posY] == null;
        public int SizeX => _sizeX;
        public int SizeY => _sizeY;

        public Map(int sizeX, int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _grid = new Building[sizeX, sizeY];
        }

        public void PlaceBuilding(int posX, int posY, Building building)
        {
            _grid[posX, posY] = building;
        }
    }
}