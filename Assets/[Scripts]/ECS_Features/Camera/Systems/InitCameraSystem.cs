namespace _Scripts_.ECS_Features.Camera.Systems
{
    using Entitas;
    using UnityEngine;
    using Views;

    /// <summary>
    /// System for finding the camera game object, creat the entity and link entity with object
    /// </summary>
    public class InitCameraSystem : IInitializeSystem
    {
        private Contexts _contexts;

        public InitCameraSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var cameraView = Object.FindObjectOfType<CameraView>();
            if (cameraView == null) return;
            var gameEntity = _contexts.game.CreateEntity();
            cameraView.Link(gameEntity);
        }
    }
}