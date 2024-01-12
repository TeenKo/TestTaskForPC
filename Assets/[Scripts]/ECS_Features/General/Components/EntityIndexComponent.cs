namespace _Scripts_.ECS_Features.General.Components
{
    using Entitas;
    using Entitas.CodeGeneration.Attributes;

    /// <summary>
    /// Component for storing a unique index of the created entity
    /// </summary>
    [Game, Input]
    public class EntityIndexComponent : IComponent
    {
        [PrimaryEntityIndex]
        public int value;
    }
}