namespace _Scripts_.ECS_Features.ClickableObject.Components
{
    using Entitas;
    using UnityEngine;

    /// <summary>
    /// Component store the start position when clickable object ois selected
    /// </summary>
    [Game]
    public class ClickableObjectSelectedPosition : IComponent
    {
        public Vector3 value;
    }
}