namespace _Scripts_.ECS_Features.General.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component for storing the layerMask
    /// </summary>
    [Game]
    public class LayerMaskComponent : IComponent
    {
        public LayerMask value;
    }
}