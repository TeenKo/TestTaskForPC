namespace _Scripts_.ECS_Features.Spawner
{
    using Systems;

    public sealed class SpawnerFeature : Feature
    {
        public SpawnerFeature(Contexts contexts)
        {
            Add(new InitSpawnerSystem(contexts));
            Add(new SpawnObjectSystem(contexts));
        }
    }
}