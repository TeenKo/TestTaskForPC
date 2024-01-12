namespace _Scripts_.ECS_Features.Input.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component the flag for click mouse left button
    /// </summary>
    [Input]
    public class MouseClickDownPositionComponent : IComponent
    {
        public Vector3 value;
    }
}