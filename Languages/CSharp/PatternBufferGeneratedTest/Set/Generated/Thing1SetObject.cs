
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Set {
    public class Thing1SetObject : IEquatable <Thing1SetObject>, IThing1SetObject {
        public Thing1SetObject() {
            this.thingSetValue = default(HashSet<IThing1>);
        }

        public Thing1SetObject(
            HashSet<IThing1> thingSetValue
        ) {
            this.thingSetValue = thingSetValue;
        }

        internal HashSet<IThing1> thingSetValue;
        public HashSet<IThing1> ThingSetValue {
            get { return this.thingSetValue; }
            set { this.thingSetValue = value; }
        }

        public bool Equals(Thing1SetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing1SetObject)) { return false; }
            Thing1SetObject that = (Thing1SetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thingSetValue
            if (this.thingSetValue == null && that.thingSetValue != null) { return false; }
            if (that.thingSetValue != null && this.thingSetValue == null) { return false; }
            if (this.thingSetValue.Count != that.thingSetValue.Count) { return false; }
            HashSet<IThing1>.Enumerator enumerator_dc81279ac8 = this.thingSetValue.GetEnumerator();
            HashSet<IThing1>.Enumerator enumerator_b3e5c67bfa = that.thingSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_dc81279ac8.MoveNext()) { break; }
                enumerator_b3e5c67bfa.MoveNext();
            if (enumerator_dc81279ac8.Current == null && enumerator_b3e5c67bfa.Current != null) { return false; }
            if (enumerator_b3e5c67bfa.Current != null && enumerator_dc81279ac8.Current == null) { return false; }
            if ( ! enumerator_dc81279ac8.Current.Equals(enumerator_b3e5c67bfa.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thingSetValue == null ? 0 : thingSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
