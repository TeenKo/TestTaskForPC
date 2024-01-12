namespace _Scripts_.ECS_Features.Spawner.Systems
{
    using Entitas;
    using UnityEngine;
    using Object = UnityEngine.Object;

    /// <summary>
    /// System for catch the request of spawn game object 
    /// </summary>
    public class SpawnObjectSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _requestGroup;
        private readonly IGroup<GameEntity> _spawnerGroup;

        public SpawnObjectSystem(Contexts contexts)
        {
            _contexts = contexts;
            
            _requestGroup = contexts.game.GetGroup(GameMatcher.SpawnObjectRequest);
            
            _spawnerGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Spawner,
                    GameMatcher.SpawnContent, 
                    GameMatcher.GameObjectType));
        }
        
        public void Execute()
        {
            foreach (var requestEntity in _requestGroup.GetEntities())
            {
                var gameObjectType = requestEntity.spawnObjectRequest.value;
                
                foreach (var spawnerEntity in _spawnerGroup.GetEntities())
                {
                    var spawnerGameObjectType = spawnerEntity.gameObjectType.value;
                    if(spawnerGameObjectType != gameObjectType)
                        continue;

                    var content = spawnerEntity.spawnContent.value;
                    var position = spawnerEntity.transform.value.position;

                    var contentView = Object.Instantiate(content, position, Quaternion.identity);
                    var contentEntity = _contexts.game.CreateEntity();
                    contentView.Link(contentEntity);
                }
                
                requestEntity.Destroy();
            }
        }
    }
}