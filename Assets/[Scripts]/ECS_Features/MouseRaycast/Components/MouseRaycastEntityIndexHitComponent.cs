namespace _Scripts_.ECS_Features.MouseRaycast.Components
{
    using Entitas;

    /// <summary>
    /// Component storing entity index from mouse raycast hit 
    /// </summary>
    [Game]
    public class MouseRaycastEntityIndexHitComponent : IComponent
    {
        public int value;
    }
}