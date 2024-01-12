namespace _Scripts_.ECS_Features.Spawner.Components.Requests
{
    using Data;
    using Entitas;

    /// <summary>
    /// Request for spawn game object
    /// </summary>
    [Game]
    public class SpawnObjectRequest : IComponent
    {
        public GameObjectType value;
    }
}