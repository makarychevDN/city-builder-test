using Scripts.Application;
using Scripts.Application.UseCases;
using Scripts.Domain.Gameplay.Models;
using Scripts.Infrastructure.Gameplay;
using Scripts.Presentation;
using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Scripts.Infrastructure.Installers
{
    public class Installer : LifetimeScope
    {
        [SerializeField] private GameObject buildingPrefab;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register(resolver => new Map(32, 32), Lifetime.Singleton);
            builder.Register<PlaceBuilding>(Lifetime.Singleton);
            builder.Register<MoveBuilding>(Lifetime.Singleton);
            builder.Register<UpgradeBuilding>(Lifetime.Singleton);
            builder.Register<RemoveBuilding>(Lifetime.Singleton);

            builder.Register<RandomTextContainerModel>(Lifetime.Singleton);
            builder.Register<BuildingSpawner>(Lifetime.Singleton);
            builder.Register<RandomTextContainerUpdateTextUseCase>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<RandomTextContainerView>();
            builder.RegisterComponentInHierarchy<SpawnPrefabButtonView>();

            builder.Register<IBuildingPlacedEvent>(
                resolver => new BuildingPlacedEventHandler(buildingPrefab),
                Lifetime.Singleton);
        }
    }
}
