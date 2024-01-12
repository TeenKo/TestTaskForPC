namespace _Scripts_.ECS_Features.Outline
{
    using Systems;

    public sealed class OutlineFeature : Feature
    {
        public OutlineFeature(Contexts contexts)
        {
            Add(new ActivateObjectOutlineSystem(contexts));
        }
    }
}