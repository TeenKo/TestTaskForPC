namespace _Scripts_.ECS_Features.Ground
{
    using Systems;

    public sealed class GroundFeature : Feature
    {
        public GroundFeature(Contexts contexts)
        {
            Add(new InitGroundSystem(contexts));
        }
    }
}