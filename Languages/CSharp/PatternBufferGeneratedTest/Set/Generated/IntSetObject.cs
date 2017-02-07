
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class IntSetObject : ISetTestObject, IEquatable<IntSetObject> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<int> IntSetValue;

        public IntSetObject() {
            this.IntSetValue = default(HashSet<int>);
        }

        public IntSetObject(
            HashSet<int> intSetValue
        ) {
            this.IntSetValue = intSetValue;
        }

        public bool Equals(IntSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntSetObject)) { return false; }
            IntSetObject that = (IntSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntSetValue
            if (this.IntSetValue == null && that.IntSetValue != null) { return false; }
            if (that.IntSetValue != null && this.IntSetValue == null) { return false; }
            if (this.IntSetValue.Count != that.IntSetValue.Count) { return false; }
            HashSet<int>.Enumerator enumerator_w9KC61kJv5sq = this.IntSetValue.GetEnumerator();
            HashSet<int>.Enumerator enumerator_aqBPP3MhzHpE = that.IntSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_w9KC61kJv5sq.MoveNext()) { break; }
                enumerator_aqBPP3MhzHpE.MoveNext();
            if (enumerator_w9KC61kJv5sq.Current != enumerator_aqBPP3MhzHpE.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntSetValue == null ? 0 : this.IntSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
