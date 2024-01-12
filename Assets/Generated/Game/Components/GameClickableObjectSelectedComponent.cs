//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedComponent clickableObjectSelectedComponent = new _Scripts_.ECS_Features.ClickableObject.Components.ClickableObjectSelectedComponent();

    public bool isClickableObjectSelected {
        get { return HasComponent(GameComponentsLookup.ClickableObjectSelected); }
        set {
            if (value != isClickableObjectSelected) {
                var index = GameComponentsLookup.ClickableObjectSelected;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : clickableObjectSelectedComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherClickableObjectSelected;

    public static Entitas.IMatcher<GameEntity> ClickableObjectSelected {
        get {
            if (_matcherClickableObjectSelected == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ClickableObjectSelected);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherClickableObjectSelected = matcher;
            }

            return _matcherClickableObjectSelected;
        }
    }
}
