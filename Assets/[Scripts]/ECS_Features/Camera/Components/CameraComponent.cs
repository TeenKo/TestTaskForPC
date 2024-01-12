namespace _Scripts_.ECS_Features.Camera.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component the flag that entity is camera
    /// </summary>
    [Game]
    public class CameraComponent : IComponent
    {
        public Camera value;
    }
}