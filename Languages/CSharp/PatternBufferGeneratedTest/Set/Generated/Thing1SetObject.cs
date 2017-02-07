
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

        public HashSet<Thing1> ThingSetValue;

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
            if (other == null) { return false; }
            if ( ! (other is Thing1SetObject)) { return false; }
            Thing1SetObject that = (Thing1SetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingSetValue
            if (this.ThingSetValue == null && that.ThingSetValue != null) { return false; }
            if (that.ThingSetValue != null && this.ThingSetValue == null) { return false; }
            if (this.ThingSetValue.Count != that.ThingSetValue.Count) { return false; }
            HashSet<Thing1>.Enumerator enumerator_ncBhp3VuTfdr = this.ThingSetValue.GetEnumerator();
            HashSet<Thing1>.Enumerator enumerator_pjtusqsvrBjt = that.ThingSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_ncBhp3VuTfdr.MoveNext()) { break; }
                enumerator_pjtusqsvrBjt.MoveNext();
            if (enumerator_ncBhp3VuTfdr.Current == null && enumerator_pjtusqsvrBjt.Current != null) { return false; }
            if (enumerator_pjtusqsvrBjt.Current != null && enumerator_ncBhp3VuTfdr.Current == null) { return false; }
            if ( ! enumerator_ncBhp3VuTfdr.Current.Equals(enumerator_pjtusqsvrBjt.Current)) { return false; }
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
