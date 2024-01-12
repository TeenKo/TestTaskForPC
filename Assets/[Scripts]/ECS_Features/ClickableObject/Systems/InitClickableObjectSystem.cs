namespace _Scripts_.ECS_Features.ClickableObject.Systems
{
    using Entitas;
    using UnityEngine;
    using Views;

    /// <summary>
    /// System for find the clickable object view, create the clickable object entity and link view with entity
    /// </summary>
    public class InitClickableObjectSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitClickableObjectSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Initialize()
        {
            var clickableObjectViews = Object.FindObjectsOfType<ClickableObjectView>();
            
            if(clickableObjectViews is null)
                return;

            foreach (var clickableObjectView in clickableObjectViews)
            {
                var clickableObjectEntity = _contexts.game.CreateEntity();
                clickableObjectView.Link(clickableObjectEntity);
            }
        }
    }
}