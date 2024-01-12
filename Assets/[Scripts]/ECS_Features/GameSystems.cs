namespace _Scripts_.ECS_Features
{
    using Camera;
    using ClickableObject;
    using Ground;
    using Input;
    using MouseRaycast;
    using Outline;
    using Spawner;

    /// <summary>
    /// Main system
    /// </summary>
    public sealed class GameSystems : Feature
    {
        public GameSystems(Contexts contexts)
        {
            Add(new CameraFeature(contexts));

            Add(new InputFeature(contexts));
            Add(new MouseRaycastFeature(contexts));

            Add(new GroundFeature(contexts));
            Add(new ClickableObjectFeature(contexts));

            Add(new OutlineFeature(contexts));
            
            Add(new SpawnerFeature(contexts));

            Add(new GameEventSystems(contexts));
        }
    }
}