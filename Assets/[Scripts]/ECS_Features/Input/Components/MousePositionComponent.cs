namespace _Scripts_.ECS_Features.Input.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Mouse position component
    /// </summary>
    [Input]
    public class MousePositionComponent : IComponent
    {
        public Vector3 value;
    }
}