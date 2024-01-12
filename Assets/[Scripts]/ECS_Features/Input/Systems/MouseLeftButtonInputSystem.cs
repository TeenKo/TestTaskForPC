namespace _Scripts_.ECS_Features.Input.Systems
{
    using Data;
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// System for control mouse left button
    /// </summary>
    public class MouseLeftButtonInputSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<InputEntity> _mouseGroup;

        public MouseLeftButtonInputSystem(Contexts contexts)
        {
            _contexts = contexts;
            _mouseGroup = contexts.input.GetGroup(
                InputMatcher.AllOf(
                    InputMatcher.Mouse,
                    InputMatcher.MouseLeftClickPhase,
                    InputMatcher.MouseLeftClickPhase));
        }

        public void Execute()
        {
            foreach (var mouseEntity in _mouseGroup.GetEntities())
            {
                var mousePosition = mouseEntity.mousePosition.value;
                var phase = mouseEntity.mouseLeftClickPhase.value;

                if (Input.GetMouseButtonDown(0))
                {
                    if (mouseEntity.hasMouseClickDownPosition is false)
                        mouseEntity.AddMouseClickDownPosition(mousePosition);
                    
                    phase = ClickPhase.Down;
                }
                else if (Input.GetMouseButton(0))
                {
                    var startClickDownPosition = mouseEntity.mouseClickDownPosition.value;

                    phase = mousePosition == startClickDownPosition
                        ? ClickPhase.Down
                        : ClickPhase.Move;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    phase = ClickPhase.Up;
                    mouseEntity.RemoveMouseClickDownPosition();
                }

                mouseEntity.ReplaceMouseLeftClickPhase(phase);
            }
        }
    }
}