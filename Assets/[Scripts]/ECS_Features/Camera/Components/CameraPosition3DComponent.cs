namespace _Scripts_.ECS_Features.Camera.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component store the camera position and rotation for 3D
    /// </summary>
    [Game]
    public class CameraPosition3DComponent : IComponent
    {
        public Vector3 position;
        public Vector3 rotation;
    }
}