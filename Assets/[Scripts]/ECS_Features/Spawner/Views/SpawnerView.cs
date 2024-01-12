namespace _Scripts_.ECS_Features.Spawner.Views
{
    using Data;
    using Game.Views;
    using UnityEngine;

    public class SpawnerView : GameView
    {
        [SerializeField]
        private GameObjectType gameObjectType;

        [SerializeField]
        private GameView content;
        public override void Link(GameEntity gameEntity)
        {
            base.Link(gameEntity);
            gameEntity.isSpawner = true;
            gameEntity.AddGameObjectType(gameObjectType);
            gameEntity.AddSpawnContent(content);
        }
    }
}