namespace _Scripts_.ECS_Features
{
    using UnityEngine;

    public class GameCore : MonoBehaviour
    {
        private Contexts contexts;
        private GameSystems gameSystems;
        
        private void Awake()
        {
            contexts = Contexts.sharedInstance;
            gameSystems = new GameSystems(contexts);
        }

        private void Start()
        {
            gameSystems.Initialize();
        }

        private void Update()
        {
            gameSystems.Execute();
            gameSystems.Cleanup();
        }
    }
}