namespace _Scripts_.ECS_Features.Outline.Systems
{
    using Entitas;

    /// <summary>
    /// System for compare the entity index from mouse with clickable object entity and off or on outline
    /// </summary>
    public class ActivateObjectOutlineSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _mouseRaycastGroup;
        private readonly IGroup<GameEntity> _clicableObjectGtoup;

        public ActivateObjectOutlineSystem(Contexts contexts)
        {
            _contexts = contexts;

            _mouseRaycastGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.MouseRaycast,
                    GameMatcher.MouseRaycastEntityIndexHit));

            _clicableObjectGtoup =
                contexts.game.GetGroup(
                    GameMatcher.AllOf(
                        GameMatcher.ClickableObject,
                        GameMatcher.OutlineObject));
        }

        public void Execute()
        {
            foreach (var mouseRaycastEntity in _mouseRaycastGroup.GetEntities())
            {
                var raycastEntityIndex = mouseRaycastEntity.mouseRaycastEntityIndexHit.value;

                foreach (var clickableObjectEntity in _clicableObjectGtoup.GetEntities())
                {
                    var entityIndex = clickableObjectEntity.entityIndex.value;
                    var isEquals = raycastEntityIndex == entityIndex;
                    var isSelected = clickableObjectEntity.isClickableObjectSelected;
                    var outlineObject = isEquals || isSelected;
                    
                    clickableObjectEntity.ReplaceOutlineObject(outlineObject);
                }
            }
        }
    }
}