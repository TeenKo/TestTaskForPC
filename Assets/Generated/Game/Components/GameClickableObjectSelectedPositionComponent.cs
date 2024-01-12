//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition clickableObjectSelectedPosition { get { return (_Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition)GetComponent(GameComponentsLookup.ClickableObjectSelectedPosition); } }
    public bool hasClickableObjectSelectedPosition { get { return HasComponent(GameComponentsLookup.ClickableObjectSelectedPosition); } }

    public void AddClickableObjectSelectedPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ClickableObjectSelectedPosition;
        var component = (_Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition)CreateComponent(index, typeof(_Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClickableObjectSelectedPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.ClickableObjectSelectedPosition;
        var component = (_Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition)CreateComponent(index, typeof(_Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedPosition));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveClickableObjectSelectedPosition() {
        RemoveComponent(GameComponentsLookup.ClickableObjectSelectedPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherClickableObjectSelectedPosition;

    public static Entitas.IMatcher<GameEntity> ClickableObjectSelectedPosition {
        get {
            if (_matcherClickableObjectSelectedPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ClickableObjectSelectedPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherClickableObjectSelectedPosition = matcher;
            }

            return _matcherClickableObjectSelectedPosition;
        }
    }
}
