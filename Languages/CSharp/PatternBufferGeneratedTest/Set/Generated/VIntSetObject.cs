
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Set {
    public class VIntSetObject : IEquatable <VIntSetObject>, IVIntSetObject {
        public VIntSetObject() {
            this.vintSetValue = default(HashSet<int>);
        }

        public VIntSetObject(
            HashSet<int> vintSetValue
        ) {
            this.vintSetValue = vintSetValue;
        }

        internal HashSet<int> vintSetValue;
        public HashSet<int> VintSetValue {
            get { return this.vintSetValue; }
            set { this.vintSetValue = value; }
        }

        public bool Equals(VIntSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntSetObject)) { return false; }
            VIntSetObject that = (VIntSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vintSetValue
            if (this.vintSetValue == null && that.vintSetValue != null) { return false; }
            if (that.vintSetValue != null && this.vintSetValue == null) { return false; }
            if (this.vintSetValue.Count != that.vintSetValue.Count) { return false; }
            HashSet<int>.Enumerator enumerator_cbe448c706 = this.vintSetValue.GetEnumerator();
            HashSet<int>.Enumerator enumerator_d079d0a8b2 = that.vintSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_cbe448c706.MoveNext()) { break; }
                enumerator_d079d0a8b2.MoveNext();
            if (enumerator_cbe448c706.Current != enumerator_d079d0a8b2.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (vintSetValue == null ? 0 : vintSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
