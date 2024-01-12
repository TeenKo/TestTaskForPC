namespace _Scripts_.ECS_Features.ClickableObject.Systems
{
    using Entitas;
    using Input.Data;

    /// <summary>
    /// System for add or remove selected clickable object component
    /// </summary>
    public class SelectedClickableObjectSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _clickableObjectGroup;

        public SelectedClickableObjectSystem(Contexts contexts)
        {
            _contexts = contexts;

            _clickableObjectGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.ClickableObject,
                    GameMatcher.OutlineObject));
        }

        public void Execute()
        {
            foreach (var clickableObjectEntity in _clickableObjectGroup.GetEntities())
            {
                var mouseEntity = _contexts.input.mouseEntity;
                if (mouseEntity.hasMouseLeftClickPhase is false)
                    continue;

                var isOutline = clickableObjectEntity.outlineObject.value;
                var phase = mouseEntity.mouseLeftClickPhase.value;

                if (phase is ClickPhase.Up)
                {
                    clickableObjectEntity.isClickableObjectSelected = false;
                    
                    if (clickableObjectEntity.hasClickableObjectSelectedPosition)
                        clickableObjectEntity.RemoveClickableObjectSelectedPosition();
                    
                    continue;
                }

                if (isOutline is false)
                    continue;

                if (clickableObjectEntity.hasClickableObjectSelectedPosition is false)
                {
                    var position = clickableObjectEntity.transform.value.position;
                    clickableObjectEntity.AddClickableObjectSelectedPosition(position);
                }

                clickableObjectEntity.isClickableObjectSelected = true;
            }
        }
    }
}