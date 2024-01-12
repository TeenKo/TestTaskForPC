namespace _Scripts_.ECS_Features.General.Components
{
    using Entitas;
    using Spawner.Data;

    /// <summary>
    /// Component store game object type
    /// </summary>
    [Game]
    public class GameObjectTypeComponent : IComponent
    {
        public GameObjectType value;
    }
}