namespace _Scripts_.ECS_Features.Camera
{
    using Systems;

    public sealed class CameraFeature : Feature
    {
        public CameraFeature(Contexts contexts)
        {
            Add(new InitCameraSystem(contexts));
            Add(new ChangeCameraTo3DSystem(contexts));
            Add(new ChangeCameraTo2DSystem(contexts));
        }
    }
}