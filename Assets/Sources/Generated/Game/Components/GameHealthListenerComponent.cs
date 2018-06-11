//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public HealthListenerComponent healthListener { get { return (HealthListenerComponent)GetComponent(GameComponentsLookup.HealthListener); } }
    public bool hasHealthListener { get { return HasComponent(GameComponentsLookup.HealthListener); } }

    public void AddHealthListener(System.Collections.Generic.List<IHealthListener> newValue) {
        var index = GameComponentsLookup.HealthListener;
        var component = CreateComponent<HealthListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceHealthListener(System.Collections.Generic.List<IHealthListener> newValue) {
        var index = GameComponentsLookup.HealthListener;
        var component = CreateComponent<HealthListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveHealthListener() {
        RemoveComponent(GameComponentsLookup.HealthListener);
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

    static Entitas.IMatcher<GameEntity> _matcherHealthListener;

    public static Entitas.IMatcher<GameEntity> HealthListener {
        get {
            if (_matcherHealthListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HealthListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHealthListener = matcher;
            }

            return _matcherHealthListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddHealthListener(IHealthListener value) {
        var listeners = hasHealthListener
            ? healthListener.value
            : new System.Collections.Generic.List<IHealthListener>();
        listeners.Add(value);
        ReplaceHealthListener(listeners);
    }

    public void RemoveHealthListener(IHealthListener value, bool removeComponentWhenEmpty = true) {
        var listeners = healthListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveHealthListener();
        } else {
            ReplaceHealthListener(listeners);
        }
    }
}
