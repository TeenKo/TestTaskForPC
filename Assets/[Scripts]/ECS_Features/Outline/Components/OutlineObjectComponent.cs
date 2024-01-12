namespace _Scripts_.ECS_Features.Outline.Components
{
    using Entitas;
    using Entitas.CodeGeneration.Attributes;

    /// <summary>
    /// Component is mark that object needs outline or not
    /// </summary>
    [Game, Event(EventTarget.Self)]
    public class OutlineObjectComponent : IComponent
    {
        public bool value;
    }
}