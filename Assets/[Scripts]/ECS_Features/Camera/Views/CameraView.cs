namespace _Scripts_.ECS_Features.Camera.Views
{
    using Game.Views;
    using UnityEngine;

    public class CameraView : GameView
    {
        [SerializeField]
        private Camera camera;

        [Space(10)]
        [SerializeField]
        private Vector3 cameraPosition3D;
        [SerializeField]
        private Vector3 cameraRotation3D;

        [Space(10)]
        [SerializeField]
        private Vector3 cameraPosition2D;
        [SerializeField]
        private Vector3 cameraRotation2D;
        
        private const string CameraTag = "MainCamera";
        public override void Link(GameEntity gameEntity)
        {
            base.Link(gameEntity);
            GameEntity.AddCamera(camera);
            GameEntity.AddCameraPosition3D(cameraPosition3D, cameraRotation3D);
            GameEntity.AddCameraPosition2D(cameraPosition2D, cameraRotation2D);
            GameEntity.isMainCamera = camera.tag is CameraTag;

            transform.position = cameraPosition3D;
            transform.rotation = Quaternion.Euler(cameraRotation3D);
        }
    }
}