
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class VIntSetObject : ISetTestObject, IEquatable<VIntSetObject> {

        public const ushort TYPE_ID = 16;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<int> VintSetValue;

        public VIntSetObject() {
            this.VintSetValue = default(HashSet<int>);
        }

        public VIntSetObject(
            HashSet<int> vintSetValue
        ) {
            this.VintSetValue = vintSetValue;
        }

        public bool Equals(VIntSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntSetObject)) { return false; }
            VIntSetObject that = (VIntSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VintSetValue
            if (this.VintSetValue == null && that.VintSetValue != null) { return false; }
            if (that.VintSetValue != null && this.VintSetValue == null) { return false; }
            if (this.VintSetValue.Count != that.VintSetValue.Count) { return false; }
            HashSet<int>.Enumerator enumerator_jAcod1fn4gHh = this.VintSetValue.GetEnumerator();
            HashSet<int>.Enumerator enumerator_ztSAgi21ZFFA = that.VintSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_jAcod1fn4gHh.MoveNext()) { break; }
                enumerator_ztSAgi21ZFFA.MoveNext();
            if (enumerator_jAcod1fn4gHh.Current != enumerator_ztSAgi21ZFFA.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.VintSetValue == null ? 0 : this.VintSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
