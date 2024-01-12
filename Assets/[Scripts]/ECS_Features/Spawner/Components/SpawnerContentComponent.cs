namespace _Scripts_.ECS_Features.Spawner.Components
{
    using Entitas;
    using Game.Views;

    /// <summary>
    /// Component store data of object for spawn
    /// </summary>
    [Game]
    public class SpawnContentComponent : IComponent
    {
        public GameView value;
    }
}