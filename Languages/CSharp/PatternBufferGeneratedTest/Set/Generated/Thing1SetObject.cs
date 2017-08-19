
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class Thing1SetObject : ISetTestObject, IEquatable<Thing1SetObject> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<Thing1> ThingSetValue; // (required)

        public Thing1SetObject() {
            this.ThingSetValue = default(HashSet<Thing1>);
        }

        public Thing1SetObject(
            HashSet<Thing1> thingSetValue
        ) {
            this.ThingSetValue = thingSetValue;
        }

        public bool Equals(Thing1SetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is Thing1SetObject)) { return false; }
            Thing1SetObject that = (Thing1SetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingSetValue (required)
                if (this.ThingSetValue == null && that.ThingSetValue != null) { return false; }
                if (that.ThingSetValue != null && this.ThingSetValue == null) { return false; }
            if (this.ThingSetValue != null && that.ThingSetValue != null) {
                if (this.ThingSetValue.Count != that.ThingSetValue.Count) { return false; }
                HashSet<Thing1>.Enumerator enumerator_lAtTzjsSFKIc = this.ThingSetValue.GetEnumerator();
                HashSet<Thing1>.Enumerator enumerator_jnEPIlQ6H4Zd = that.ThingSetValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_lAtTzjsSFKIc.MoveNext()) { break; }
                    enumerator_jnEPIlQ6H4Zd.MoveNext();
            if ( ! (enumerator_lAtTzjsSFKIc.Current == null && enumerator_jnEPIlQ6H4Zd.Current == null)) {
                if (enumerator_lAtTzjsSFKIc.Current == null && enumerator_jnEPIlQ6H4Zd.Current != null) { return false; }
                if (enumerator_jnEPIlQ6H4Zd.Current != null && enumerator_lAtTzjsSFKIc.Current == null) { return false; }
            if ( ! enumerator_lAtTzjsSFKIc.Current.Equals(enumerator_jnEPIlQ6H4Zd.Current)) { return false; }
            }
                }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingSetValue == null ? 0 : this.ThingSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
