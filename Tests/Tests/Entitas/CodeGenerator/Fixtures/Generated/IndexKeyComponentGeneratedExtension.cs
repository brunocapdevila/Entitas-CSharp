//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        public IndexKeyComponent indexKey { get { return (IndexKeyComponent)GetComponent(ComponentIds.IndexKey); } }

        public bool hasIndexKey { get { return HasComponent(ComponentIds.IndexKey); } }

        public Entity AddIndexKey(string newName) {
            var component = CreateComponent<IndexKeyComponent>(ComponentIds.IndexKey);
            component.name = newName;
            AddComponent(ComponentIds.IndexKey, component);
            return this;
        }

        public Entity ReplaceIndexKey(string newName) {
            var component = CreateComponent<IndexKeyComponent>(ComponentIds.IndexKey);
            component.name = newName;
            ReplaceComponent(ComponentIds.IndexKey, component);
            return this;
        }

        public Entity RemoveIndexKey() {
            RemoveComponent(ComponentIds.IndexKey);
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherIndexKey;

        public static IMatcher IndexKey {
            get {
                if (_matcherIndexKey == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.IndexKey);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherIndexKey = matcher;
                }

                return _matcherIndexKey;
            }
        }
    }
}
