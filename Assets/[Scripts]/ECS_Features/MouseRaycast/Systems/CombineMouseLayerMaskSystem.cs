namespace _Scripts_.ECS_Features.MouseRaycast.Systems
{
    using Entitas;
    using Input.Data;
    using UnityEngine;

    /// <summary>
    /// System for combine the layer masks to one the layer mask for mouse 
    /// </summary>
    public class CombineMouseLayerMaskSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        private readonly IGroup<GameEntity> _layerMaskGorup;
        private readonly IGroup<GameEntity> _mouseRaycastGroup;

        private LayerMask _groundLayerMask = 1 << 3;

        public CombineMouseLayerMaskSystem(Contexts contexts)
        {
            _contexts = contexts;

            _mouseRaycastGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.MouseRaycast,
                    GameMatcher.LayerMask));

            _layerMaskGorup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.LayerMask,
                    GameMatcher.LayerMaskForMouse));
        }

        public void Execute()
        {
            foreach (var mouseRaycastEntity in _mouseRaycastGroup.GetEntities())
            {
                var mouseLayerMask = mouseRaycastEntity.layerMask.value;
                var mouseEntity = _contexts.input.mouseEntity;
                
                foreach (var layerMaskEntity in _layerMaskGorup.GetEntities())
                {
                    if (mouseEntity.hasMouseLeftClickPhase && mouseEntity.mouseLeftClickPhase.value is ClickPhase.Move)
                    {
                        mouseLayerMask = _groundLayerMask;
                        continue;
                    }
                    
                    var layerMask = layerMaskEntity.layerMask.value;
                    mouseLayerMask |= layerMask;
                }
                
                mouseRaycastEntity.ReplaceLayerMask(mouseLayerMask);
            }
        }
    }
}