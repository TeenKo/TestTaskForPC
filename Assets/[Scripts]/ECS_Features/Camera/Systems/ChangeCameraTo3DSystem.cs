namespace _Scripts_.ECS_Features.Camera.Systems
{
    using System;
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// System for change camera to 3D orientation 
    /// </summary>
    public class ChangeCameraTo3DSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _requestGroup;
        private readonly IGroup<GameEntity> _cameraGroup;

        public ChangeCameraTo3DSystem(Contexts contexts)
        {
            _contexts = contexts;
            
            _requestGroup = contexts.game.GetGroup(GameMatcher.ChangeCameraTo3DRequest);
            
            _cameraGroup = contexts.game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.Camera,
                    GameMatcher.MainCamera,
                    GameMatcher.CameraPosition3D));
        }
        
        public void Execute()
        {
            foreach (var requestEntity in _requestGroup.GetEntities())
            {
                foreach (var cameraEntity in _cameraGroup.GetEntities())
                {
                    var transform = cameraEntity.transform.value;
                    var position = cameraEntity.cameraPosition3D.position;
                    var rotation = cameraEntity.cameraPosition3D.rotation;

                    transform.position = position;
                    transform.rotation = Quaternion.Euler(rotation);
                }
                
                requestEntity.Destroy();
            }
        }
    }
}