//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectComponent clickableObjectComponent = new _Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectComponent();

    public bool isClickableObject {
        get { return HasComponent(GameComponentsLookup.ClickableObject); }
        set {
            if (value != isClickableObject) {
                var index = GameComponentsLookup.ClickableObject;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : clickableObjectComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherClickableObject;

    public static Entitas.IMatcher<GameEntity> ClickableObject {
        get {
            if (_matcherClickableObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ClickableObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherClickableObject = matcher;
            }

            return _matcherClickableObject;
        }
    }
}
