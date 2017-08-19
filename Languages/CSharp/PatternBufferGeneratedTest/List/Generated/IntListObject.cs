
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

        public List<int> IntListValue; // (required)

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
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is IntListObject)) { return false; }
            IntListObject that = (IntListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntListValue (required)
                if (this.IntListValue == null && that.IntListValue != null) { return false; }
                if (that.IntListValue != null && this.IntListValue == null) { return false; }
            if (this.IntListValue != null && that.IntListValue != null) {
                if (this.IntListValue.Count != that.IntListValue.Count) { return false; }
                List<int>.Enumerator enumerator_qy2m9hpziQbS = this.IntListValue.GetEnumerator();
                List<int>.Enumerator enumerator_u2tJadGnSVUo = that.IntListValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_qy2m9hpziQbS.MoveNext()) { break; }
                    enumerator_u2tJadGnSVUo.MoveNext();
            if (enumerator_qy2m9hpziQbS.Current != enumerator_u2tJadGnSVUo.Current) { return false; }
                }
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
