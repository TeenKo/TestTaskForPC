//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Scripts_.ECS_Features.General.Components.EntityIndexComponent entityIndex { get { return (_Scripts_.ECS_Features.General.Components.EntityIndexComponent)GetComponent(GameComponentsLookup.EntityIndex); } }
    public bool hasEntityIndex { get { return HasComponent(GameComponentsLookup.EntityIndex); } }

    public void AddEntityIndex(int newValue) {
        var index = GameComponentsLookup.EntityIndex;
        var component = (_Scripts_.ECS_Features.General.Components.EntityIndexComponent)CreateComponent(index, typeof(_Scripts_.ECS_Features.General.Components.EntityIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEntityIndex(int newValue) {
        var index = GameComponentsLookup.EntityIndex;
        var component = (_Scripts_.ECS_Features.General.Components.EntityIndexComponent)CreateComponent(index, typeof(_Scripts_.ECS_Features.General.Components.EntityIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEntityIndex() {
        RemoveComponent(GameComponentsLookup.EntityIndex);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity : IEntityIndexEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEntityIndex;

    public static Entitas.IMatcher<GameEntity> EntityIndex {
        get {
            if (_matcherEntityIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EntityIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEntityIndex = matcher;
            }

            return _matcherEntityIndex;
        }
    }
}
