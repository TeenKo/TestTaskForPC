namespace _Scripts_.ECS_Features.Input.Systems
{
    using Data;
    using Entitas;

    /// <summary>
    /// System for create input entities
    /// </summary>
    public class InitInputSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitInputSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var inputEntity = _contexts.input.CreateEntity();
            inputEntity.isMouse = true;
            inputEntity.AddEntityIndex(inputEntity.creationIndex);
            inputEntity.AddMouseLeftClickPhase(ClickPhase.Up);
        }
    }
}