namespace _Scripts_.ECS_Features.General.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component with raycast hit information
    /// </summary>
    [Game]
    public class RaycastHitComponent : IComponent
    {
        public RaycastHit value;
    }
}