//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        static readonly SomeComponent someComponent = new SomeComponent();

        public bool isSome {
            get { return HasComponent(TestComponentIds.Some); }
            set {
                if (value != isSome) {
                    if (value) {
                        AddComponent(TestComponentIds.Some, someComponent);
                    } else {
                        RemoveComponent(TestComponentIds.Some);
                    }
                }
            }
        }

        public Entity IsSome(bool value) {
            isSome = value;
            return this;
        }
    }
}

    public partial class TestMatcher {
        static IMatcher _matcherSome;

        public static IMatcher Some {
            get {
                if (_matcherSome == null) {
                    var matcher = (Matcher)Matcher.AllOf(TestComponentIds.Some);
                    matcher.componentNames = TestComponentIds.componentNames;
                    _matcherSome = matcher;
                }

                return _matcherSome;
            }
        }
    }