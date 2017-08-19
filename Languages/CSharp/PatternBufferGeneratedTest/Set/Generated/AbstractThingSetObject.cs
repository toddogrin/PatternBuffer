
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class AbstractThingSetObject : ISetTestObject, IEquatable<AbstractThingSetObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<AbstractThing> AbstractThingSetValue; // (required)

        public AbstractThingSetObject() {
            this.AbstractThingSetValue = default(HashSet<AbstractThing>);
        }

        public AbstractThingSetObject(
            HashSet<AbstractThing> abstractThingSetValue
        ) {
            this.AbstractThingSetValue = abstractThingSetValue;
        }

        public bool Equals(AbstractThingSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThingSetObject)) { return false; }
            AbstractThingSetObject that = (AbstractThingSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // AbstractThingSetValue (required)
                if (this.AbstractThingSetValue == null && that.AbstractThingSetValue != null) { return false; }
                if (that.AbstractThingSetValue != null && this.AbstractThingSetValue == null) { return false; }
            if (this.AbstractThingSetValue != null && that.AbstractThingSetValue != null) {
                if (this.AbstractThingSetValue.Count != that.AbstractThingSetValue.Count) { return false; }
                HashSet<AbstractThing>.Enumerator enumerator_sErsEQ7OY66Z = this.AbstractThingSetValue.GetEnumerator();
                HashSet<AbstractThing>.Enumerator enumerator_bFWVVE8eA6Rs = that.AbstractThingSetValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_sErsEQ7OY66Z.MoveNext()) { break; }
                    enumerator_bFWVVE8eA6Rs.MoveNext();
            if ( ! (enumerator_sErsEQ7OY66Z.Current == null && enumerator_bFWVVE8eA6Rs.Current == null)) {
                if (enumerator_sErsEQ7OY66Z.Current == null && enumerator_bFWVVE8eA6Rs.Current != null) { return false; }
                if (enumerator_bFWVVE8eA6Rs.Current != null && enumerator_sErsEQ7OY66Z.Current == null) { return false; }
            if ( ! enumerator_sErsEQ7OY66Z.Current.Equals(enumerator_bFWVVE8eA6Rs.Current)) { return false; }
            }
                }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.AbstractThingSetValue == null ? 0 : this.AbstractThingSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
