namespace _Scripts_.ECS_Features.Ground.Views
{
    using Game.Views;

    public class GroundView : GameView
    {
        public override void Link(GameEntity gameEntity)
        {
            base.Link(gameEntity);
            gameEntity.isGround = true;
            gameEntity.isLayerMaskForMouse = true;
            gameEntity.AddLayerMask(1 << gameObject.layer);
        }
    }
}