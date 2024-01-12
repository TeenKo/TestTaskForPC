namespace _Scripts_.ECS_Features.Input.Components
{
    using Data;
    using Entitas;

    /// <summary>
    /// Component storing the mouse left button click phase  
    /// </summary>
    [Input]
    public class MouseLeftClickPhaseComponent : IComponent
    {
        public ClickPhase value;
    }
}