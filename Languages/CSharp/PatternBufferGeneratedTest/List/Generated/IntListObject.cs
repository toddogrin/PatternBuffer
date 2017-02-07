
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class IntListObject : IListTestObject, IEquatable<IntListObject> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<int> IntListValue;

        public IntListObject() {
            this.IntListValue = default(List<int>);
        }

        public IntListObject(
            List<int> intListValue
        ) {
            this.IntListValue = intListValue;
        }

        public bool Equals(IntListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntListObject)) { return false; }
            IntListObject that = (IntListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntListValue
            if (this.IntListValue == null && that.IntListValue != null) { return false; }
            if (that.IntListValue != null && this.IntListValue == null) { return false; }
            if (this.IntListValue.Count != that.IntListValue.Count) { return false; }
            List<int>.Enumerator enumerator_hnBzsS5GrKlK = this.IntListValue.GetEnumerator();
            List<int>.Enumerator enumerator_hZG4cwZyzh7c = that.IntListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_hnBzsS5GrKlK.MoveNext()) { break; }
                enumerator_hZG4cwZyzh7c.MoveNext();
            if (enumerator_hnBzsS5GrKlK.Current != enumerator_hZG4cwZyzh7c.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntListValue == null ? 0 : this.IntListValue.GetHashCode());
                return hash;
            }
        }
    }
}
