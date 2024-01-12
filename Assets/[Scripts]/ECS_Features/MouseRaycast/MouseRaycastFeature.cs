namespace _Scripts_.ECS_Features.MouseRaycast
{
    using Systems;

    public sealed class MouseRaycastFeature : Feature
    {
        public MouseRaycastFeature(Contexts contexts)
        {
            Add(new InitMouseRaycastSystem(contexts));
            Add(new CombineMouseLayerMaskSystem(contexts));
            Add(new GetFirstMouseRaycastHitSystem(contexts));
            Add(new GetEntityFromMouseRaycastSystem(contexts));
        }
    }
}