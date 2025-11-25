using Scripts.Domain.Gameplay.Models;

namespace Scripts.Application.UseCases
{
    public interface IRandomTextContainerUpdateTextUseCase
    {
        string Execute();
    }

    public class RandomTextContainerUpdateTextUseCase : IRandomTextContainerUpdateTextUseCase
    {
        private readonly RandomTextContainerModel _textModel;

        public RandomTextContainerUpdateTextUseCase(RandomTextContainerModel textModel)
        {
            _textModel = textModel;
        }

        public string Execute()
        {
            _textModel.Randomize();
            return _textModel.Current;
        }
    }
}