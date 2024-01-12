namespace _Scripts_.ECS_Features.MouseRaycast.Systems
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// System for create mouse raycast entity
    /// </summary>
    public class InitMouseRaycastSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private LayerMask _layerMask;

        public InitMouseRaycastSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var raycastEntity = _contexts.game.CreateEntity();
            raycastEntity.isMouseRaycast = true;
            raycastEntity.AddEntityIndex(raycastEntity.creationIndex);
            raycastEntity.AddLayerMask(_layerMask);
            raycastEntity.AddDistance(Mathf.Infinity);
        }
    }
}