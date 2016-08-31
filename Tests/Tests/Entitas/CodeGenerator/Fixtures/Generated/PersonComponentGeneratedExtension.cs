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

        public PersonComponent person { get { return (PersonComponent)GetComponent(ComponentIds.Person); } }

        public bool hasPerson { get { return HasComponent(ComponentIds.Person); } }

        public Entity AddPerson(int newAge, string newName) {
            var component = CreateComponent<PersonComponent>(ComponentIds.Person);
            component.age = newAge;
            component.name = newName;
            AddComponent(ComponentIds.Person, component);
            return this;
        }

        public Entity ReplacePerson(int newAge, string newName) {
            var component = CreateComponent<PersonComponent>(ComponentIds.Person);
            component.age = newAge;
            component.name = newName;
            ReplaceComponent(ComponentIds.Person, component);
            return this;
        }

        public Entity RemovePerson() {
            RemoveComponent(ComponentIds.Person);
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherPerson;

        public static IMatcher Person {
            get {
                if (_matcherPerson == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Person);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPerson = matcher;
                }

                return _matcherPerson;
            }
        }
    }
}
