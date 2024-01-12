namespace _Scripts_.ECS_Features.Input.Systems
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// System fore get and replace mouse position component
    /// </summary>
    public class MousePositionSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<InputEntity> _mouseGroup;

        public MousePositionSystem(Contexts contexts)
        {
            _contexts = contexts;
            _mouseGroup = _contexts.input.GetGroup(InputMatcher.Mouse);
        }

        public void Execute()
        {
            foreach (var mouseEntity in _mouseGroup.GetEntities())
            {
                var mousePosition = Input.mousePosition;
                mouseEntity.ReplaceMousePosition(mousePosition);
            }
        }
    }
}