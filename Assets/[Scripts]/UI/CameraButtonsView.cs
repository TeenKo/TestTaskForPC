namespace _Scripts_.UI
{
    using UnityEngine;

    public class CameraButtonsView : MonoBehaviour
    {
        private Contexts _contexts;
        
        public void Start()
        {
            _contexts = Contexts.sharedInstance;
        }

        public void CameraTo3D()
        {
            var requestEntity = _contexts.game.CreateEntity();
            requestEntity.isChangeCameraTo3DRequest = true;
        }
        
        public void CameraTo2D()
        {
            var requestEntity = _contexts.game.CreateEntity();
            requestEntity.isChangeCameraTo2DRequest = true;
        }
    }
}