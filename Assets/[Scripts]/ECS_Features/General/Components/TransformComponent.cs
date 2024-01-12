namespace _Scripts_.ECS_Features.General.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component for storing transform the game object
    /// </summary>
    [Game]
    public class TransformComponent : IComponent
    {
        public Transform value;
    }
}