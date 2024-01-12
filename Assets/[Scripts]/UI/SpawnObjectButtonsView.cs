namespace _Scripts_.UI
{
    using ECS_Features.Spawner.Data;
    using UnityEngine;

    public class SpawnObjectButtonsView : MonoBehaviour
    {
        [SerializeField]
        private GameObjectType addTreeButton;
        [SerializeField]
        private GameObjectType addHouseButton;
        
        private Contexts _contexts;

        public void Start()
        {
            _contexts = Contexts.sharedInstance;
        }

        public void SpawnHouse()
        {
            var requestEntity = _contexts.game.CreateEntity();
            requestEntity.AddSpawnObjectRequest(addHouseButton);
        }
        
        public void SpawnTree()
        {
            var requestEntity = _contexts.game.CreateEntity();
            requestEntity.AddSpawnObjectRequest(addTreeButton);
        }
    }
}