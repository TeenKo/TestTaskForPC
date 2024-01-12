namespace _Scripts_.ECS_Features.ClickableObject
{
    using Systems;

    public sealed class ClickableObjectFeature : Feature
    {
        public ClickableObjectFeature(Contexts contexts)
        {
            Add(new InitClickableObjectSystem(contexts));
            Add(new SelectedClickableObjectSystem(contexts));
            Add(new MoveClickableObjectSystem(contexts));
        }
    }
}