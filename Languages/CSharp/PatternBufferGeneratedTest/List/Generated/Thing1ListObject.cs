
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing1ListObject : IEquatable <Thing1ListObject>, IThing1ListObject {
        public Thing1ListObject() {
            this.thingListValue = default(List<IThing1>);
        }

        public Thing1ListObject(
            List<IThing1> thingListValue
        ) {
            this.thingListValue = thingListValue;
        }

        internal List<IThing1> thingListValue;
        public List<IThing1> ThingListValue {
            get { return this.thingListValue; }
            set { this.thingListValue = value; }
        }

        public bool Equals(Thing1ListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing1ListObject)) { return false; }
            Thing1ListObject that = (Thing1ListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thingListValue
            if (this.thingListValue == null && that.thingListValue != null) { return false; }
            if (that.thingListValue != null && this.thingListValue == null) { return false; }
            if (this.thingListValue.Count != that.thingListValue.Count) { return false; }
            List<IThing1>.Enumerator enumerator_ab8a7905aa = this.thingListValue.GetEnumerator();
            List<IThing1>.Enumerator enumerator_4555d0e966 = that.thingListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_ab8a7905aa.MoveNext()) { break; }
                enumerator_4555d0e966.MoveNext();
            if (enumerator_ab8a7905aa.Current == null && enumerator_4555d0e966.Current != null) { return false; }
            if (enumerator_4555d0e966.Current != null && enumerator_ab8a7905aa.Current == null) { return false; }
            if ( ! enumerator_ab8a7905aa.Current.Equals(enumerator_4555d0e966.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thingListValue == null ? 0 : thingListValue.GetHashCode());
                return hash;
            }
        }
    }
}
