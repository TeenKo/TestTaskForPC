namespace _Scripts_.ECS_Features.Ground.Systems
{
    using Entitas;
    using UnityEngine;
    using Views;

    /// <summary>
    /// System for find the ground view, create the ground entity and link view with entity
    /// </summary>
    public class InitGroundSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitGroundSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Initialize()
        {
            var groundViews = Object.FindObjectsOfType<GroundView>(); 
            
            if(groundViews is null)
                return;

            foreach (var groundView in groundViews)
            {
                var groundEntity = _contexts.game.CreateEntity();
                groundView.Link(groundEntity);
            }
        }
    }
}