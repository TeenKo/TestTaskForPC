namespace _Scripts_.ECS_Features.Spawner.Systems
{
    using Entitas;
    using UnityEngine;
    using Views;

    /// <summary>
    /// System for find spawners on on scene, create spawner entity and link spawner and spawner entity
    /// </summary>
    public class InitSpawnerSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitSpawnerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Initialize()
        {
            var spawnerViews = Object.FindObjectsOfType<SpawnerView>();
            if(spawnerViews is null) return;

            foreach (var spawnerView in spawnerViews)
            {
                var spawnerEntity = _contexts.game.CreateEntity();
                spawnerView.Link(spawnerEntity);
            }
        }
    }
}