namespace _Scripts_.ECS_Features.ClickableObject.Views
{
    using _Scripts_.Game.Views;
    using UnityEngine;
    using Outline = global::Outline;

    public class ClickableObjectView : GameView, IOutlineObjectListener
    {
        [SerializeField]
        private Outline outline;
        public override void Link(GameEntity gameEntity)
        {
            base.Link(gameEntity);
            gameEntity.isClickableObject = true;
            gameEntity.isLayerMaskForMouse = true;
            gameEntity.AddLayerMask(1 << gameObject.layer);
            gameEntity.AddOutlineObject(false);
            
            gameEntity.AddOutlineObjectListener(this);
        }

        public void OnOutlineObject(GameEntity entity, bool value)
        {
            outline.enabled = value;
        }
    }
}