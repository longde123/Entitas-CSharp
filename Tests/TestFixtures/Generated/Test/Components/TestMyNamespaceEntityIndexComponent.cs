//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public My.Namespace.EntityIndexComponent myNamespaceEntityIndex { get { return (My.Namespace.EntityIndexComponent)GetComponent(TestComponentLookup.MyNamespaceEntityIndex); } }
    public bool hasMyNamespaceEntityIndex { get { return HasComponent(TestComponentLookup.MyNamespaceEntityIndex); } }

    public void AddMyNamespaceEntityIndex(string newValue) {
        var index = TestComponentLookup.MyNamespaceEntityIndex;
        var component = CreateComponent<My.Namespace.EntityIndexComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceEntityIndex(string newValue) {
        var index = TestComponentLookup.MyNamespaceEntityIndex;
        var component = CreateComponent<My.Namespace.EntityIndexComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceEntityIndex() {
        RemoveComponent(TestComponentLookup.MyNamespaceEntityIndex);
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
public partial class TestEntity : IMyNamespaceEntityIndexEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherMyNamespaceEntityIndex;

    public static Entitas.IMatcher<TestEntity> MyNamespaceEntityIndex {
        get {
            if (_matcherMyNamespaceEntityIndex == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentLookup.MyNamespaceEntityIndex);
                matcher.componentNames = TestComponentLookup.componentNames;
                _matcherMyNamespaceEntityIndex = matcher;
            }

            return _matcherMyNamespaceEntityIndex;
        }
    }
}
