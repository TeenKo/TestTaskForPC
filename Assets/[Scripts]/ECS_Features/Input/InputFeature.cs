namespace _Scripts_.ECS_Features.Input
{
    using Systems;

    public sealed class InputFeature : Feature
    {
        public InputFeature(Contexts contexts)
        {
            Add(new InitInputSystem(contexts));
            Add(new MousePositionSystem(contexts));
            Add(new MouseLeftButtonInputSystem(contexts));
        }
    }
}