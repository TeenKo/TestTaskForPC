namespace _Scripts_.ECS_Features.Camera.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component store the camera position and rotation for 2D
    /// </summary>
    [Game]
    public class CameraPosition2DComponent : IComponent
    {
        public Vector3 position;
        public Vector3 rotation;
    }
}