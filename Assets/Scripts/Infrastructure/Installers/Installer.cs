using Scripts.Domain.Gameplay.Models;
using Scripts.Application.UseCases;
using VContainer;
using VContainer.Unity;

namespace Scripts.Infrastructure.Installers
{
    public class Installer : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register(resolver => new Map(32, 32), Lifetime.Singleton);
            builder.Register<PlaceBuilding>(Lifetime.Singleton);
            builder.Register<MoveBuilding>(Lifetime.Singleton);
            builder.Register<UpgradeBuilding>(Lifetime.Singleton);
            builder.Register<RemoveBuilding>(Lifetime.Singleton);
        }
    }
}
