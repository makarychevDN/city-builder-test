namespace Scripts.Domain.Gameplay.Models
{
    public class RandomTextContainerModel
    {
        private readonly string[] _values =
            { "One", "Two", "Three", "Four", "Five" };

        public string Current { get; private set; }

        public void Randomize()
        {
            var index = UnityEngine.Random.Range(0, _values.Length);
            Current = _values[index];
        }
    }
}