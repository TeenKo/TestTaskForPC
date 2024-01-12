namespace _Scripts_.ECS_Features.MouseRaycast.Systems
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// System for get first mouse raycast hit 
    /// </summary>
    public class GetFirstMouseRaycastHitSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _mouseRaycastGroup;
        private readonly IGroup<GameEntity> _cameraGroup;

        public GetFirstMouseRaycastHitSystem(Contexts contexts)
        {
            _contexts = contexts;

            _cameraGroup = contexts.game.GetGroup(GameMatcher.Camera);
            
            _mouseRaycastGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.MouseRaycast,
                    GameMatcher.LayerMask,
                    GameMatcher.Distance));
        }
        
        public void Execute()
        {
            foreach (var cameraEntity in _cameraGroup.GetEntities())
            {
                var camera = cameraEntity.camera.value;
                var mouseEntity = _contexts.input.mouseEntity;
                var mousePosition = mouseEntity.mousePosition.value;
                
                foreach (var mouseRaycastEntity in _mouseRaycastGroup.GetEntities())
                {
                    var distance = mouseRaycastEntity.distance.value;
                    var layerMask = mouseRaycastEntity.layerMask.value;
                    var ray = camera.ScreenPointToRay(mousePosition);
                    var isHit = Physics.Raycast(ray, out var hit, distance, layerMask);
                    
                    if (isHit == false)
                    {
                        if(mouseRaycastEntity.hasRaycastHit) mouseRaycastEntity.RemoveRaycastHit();
                        continue;
                    }

                    mouseRaycastEntity.ReplaceRaycastHit(hit);
                }
            }

        }
    }
}