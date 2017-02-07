
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing1ListObject : IListTestObject, IEquatable<Thing1ListObject> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<Thing1> ThingListValue;

        public Thing1ListObject() {
            this.ThingListValue = default(List<Thing1>);
        }

        public Thing1ListObject(
            List<Thing1> thingListValue
        ) {
            this.ThingListValue = thingListValue;
        }

        public bool Equals(Thing1ListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is Thing1ListObject)) { return false; }
            Thing1ListObject that = (Thing1ListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingListValue
            if (this.ThingListValue == null && that.ThingListValue != null) { return false; }
            if (that.ThingListValue != null && this.ThingListValue == null) { return false; }
            if (this.ThingListValue.Count != that.ThingListValue.Count) { return false; }
            List<Thing1>.Enumerator enumerator_lq7yAodnUKYs = this.ThingListValue.GetEnumerator();
            List<Thing1>.Enumerator enumerator_j3YYUqjVlXva = that.ThingListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_lq7yAodnUKYs.MoveNext()) { break; }
                enumerator_j3YYUqjVlXva.MoveNext();
            if (enumerator_lq7yAodnUKYs.Current == null && enumerator_j3YYUqjVlXva.Current != null) { return false; }
            if (enumerator_j3YYUqjVlXva.Current != null && enumerator_lq7yAodnUKYs.Current == null) { return false; }
            if ( ! enumerator_lq7yAodnUKYs.Current.Equals(enumerator_j3YYUqjVlXva.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingListValue == null ? 0 : this.ThingListValue.GetHashCode());
                return hash;
            }
        }
    }
}
