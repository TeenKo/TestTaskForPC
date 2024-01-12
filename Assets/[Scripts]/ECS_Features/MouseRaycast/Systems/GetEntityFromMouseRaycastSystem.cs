namespace _Scripts_.ECS_Features.MouseRaycast.Systems
{
    using Entitas;
    using Entitas.Unity;

    /// <summary>
    /// System for get entity from mouse raycast hit
    /// </summary>
    public class GetEntityFromMouseRaycastSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _mouseRaycastGroup;

        public GetEntityFromMouseRaycastSystem(Contexts contexts)
        {
            _contexts = contexts;

            _mouseRaycastGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.MouseRaycast));
        }
        
        public void Execute()
        {
            foreach (var raycastEntity in _mouseRaycastGroup.GetEntities())
            {
                if (raycastEntity.hasRaycastHit is false)
                {
                    RemoveComponent(raycastEntity);
                    continue;
                }
                
                var hit = raycastEntity.raycastHit.value;
                var gameObject = hit.collider.gameObject;
                var entityLink = gameObject.GetEntityLink();
                
                if (entityLink is null)
                {
                    RemoveComponent(raycastEntity);
                    continue;
                }
                
                var hitEntity = entityLink.entity;
                
                raycastEntity.ReplaceMouseRaycastEntityIndexHit(hitEntity.creationIndex);
            }
        }

        private void RemoveComponent(GameEntity raycastEntity)
        {
            if(raycastEntity.hasMouseRaycastEntityIndexHit)
                raycastEntity.RemoveMouseRaycastEntityIndexHit();
        }
    }
}