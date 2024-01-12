namespace _Scripts_.Game.Views
{
    using Interfaces;
    using Entitas;
    using Entitas.Unity;
    using UnityEngine;

    public class GameView : MonoBehaviour, IGameEntityView
    {
        public GameEntity GameEntity;

        public virtual void Link(GameEntity gameEntity)
        {
            GameEntity = gameEntity;
            gameObject.Link(gameEntity);
            gameEntity.AddTransform(transform);
            gameEntity.AddEntityIndex(gameEntity.creationIndex);
            gameEntity.OnDestroyEntity += EntityOnOnDestroyEntity;
        }

        private void EntityOnOnDestroyEntity(IEntity entity)
        {
            entity.OnDestroyEntity -= EntityOnOnDestroyEntity;
            gameObject.Unlink();

            GameEntity = null;
            Destroy(gameObject);
        }

        private void OnDestroy()
        {
            if (gameObject.GetEntityLink() == null) return;
            if (gameObject.GetEntityLink().entity == null) return;
            GameEntity?.Destroy();
        }
    }
}