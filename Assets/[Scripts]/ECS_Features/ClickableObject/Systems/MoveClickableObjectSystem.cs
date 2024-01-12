namespace _Scripts_.ECS_Features.ClickableObject.Systems
{
    using Entitas;
    using Input.Data;
    using UnityEngine;

    /// <summary>
    /// Systems for move clickable object when mouse left click down and move
    /// </summary>
    public class MoveClickableObjectSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _clickableObjectGroup;
        private readonly IGroup<GameEntity> _raycastMouseGroup;

        public MoveClickableObjectSystem(Contexts contexts)
        {
            _contexts = contexts;

            _clickableObjectGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.ClickableObject,
                    GameMatcher.OutlineObject));

            _raycastMouseGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.MouseRaycast,
                    GameMatcher.RaycastHit));
        }

        public void Execute()
        {
            foreach (var raycastCameraEntity in _raycastMouseGroup.GetEntities())
            {
                var mouseEntity = _contexts.input.mouseEntity;
                if (mouseEntity.hasMouseLeftClickPhase is false)
                    continue;

                var phase = mouseEntity.mouseLeftClickPhase.value;
                var moveSpeed = 10f;
                
                if (phase is not ClickPhase.Move)
                    continue;

                foreach (var clickableObjectEntity in _clickableObjectGroup.GetEntities())
                {
                    var isOutline = clickableObjectEntity.outlineObject.value;
                    if (isOutline is false)
                        continue;
                    
                    var newPosition = raycastCameraEntity.raycastHit.value.point;
                    var transform = clickableObjectEntity.transform.value;
                    
                    transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * moveSpeed);
                }
            }
        }
    }
}