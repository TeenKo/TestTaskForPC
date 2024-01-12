//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent cameraPosition2D { get { return (_Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent)GetComponent(GameComponentsLookup.CameraPosition2D); } }
    public bool hasCameraPosition2D { get { return HasComponent(GameComponentsLookup.CameraPosition2D); } }

    public void AddCameraPosition2D(UnityEngine.Vector3 newPosition, UnityEngine.Vector3 newRotation) {
        var index = GameComponentsLookup.CameraPosition2D;
        var component = (_Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent)CreateComponent(index, typeof(_Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent));
        component.position = newPosition;
        component.rotation = newRotation;
        AddComponent(index, component);
    }

    public void ReplaceCameraPosition2D(UnityEngine.Vector3 newPosition, UnityEngine.Vector3 newRotation) {
        var index = GameComponentsLookup.CameraPosition2D;
        var component = (_Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent)CreateComponent(index, typeof(_Scripts_.ECS_Features.Camera.Components.CameraPosition2DComponent));
        component.position = newPosition;
        component.rotation = newRotation;
        ReplaceComponent(index, component);
    }

    public void RemoveCameraPosition2D() {
        RemoveComponent(GameComponentsLookup.CameraPosition2D);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCameraPosition2D;

    public static Entitas.IMatcher<GameEntity> CameraPosition2D {
        get {
            if (_matcherCameraPosition2D == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CameraPosition2D);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCameraPosition2D = matcher;
            }

            return _matcherCameraPosition2D;
        }
    }
}
