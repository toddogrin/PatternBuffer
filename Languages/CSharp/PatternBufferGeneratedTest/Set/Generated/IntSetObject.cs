
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Set {
    public class IntSetObject : IEquatable <IntSetObject>, IIntSetObject {
        public IntSetObject() {
            this.intSetValue = default(HashSet<int>);
        }

        public IntSetObject(
            HashSet<int> intSetValue
        ) {
            this.intSetValue = intSetValue;
        }

        internal HashSet<int> intSetValue;
        public HashSet<int> IntSetValue {
            get { return this.intSetValue; }
            set { this.intSetValue = value; }
        }

        public bool Equals(IntSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntSetObject)) { return false; }
            IntSetObject that = (IntSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intSetValue
            if (this.intSetValue == null && that.intSetValue != null) { return false; }
            if (that.intSetValue != null && this.intSetValue == null) { return false; }
            if (this.intSetValue.Count != that.intSetValue.Count) { return false; }
            HashSet<int>.Enumerator enumerator_c4c91e11eb = this.intSetValue.GetEnumerator();
            HashSet<int>.Enumerator enumerator_75a4ab73e3 = that.intSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_c4c91e11eb.MoveNext()) { break; }
                enumerator_75a4ab73e3.MoveNext();
            if (enumerator_c4c91e11eb.Current != enumerator_75a4ab73e3.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (intSetValue == null ? 0 : intSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
