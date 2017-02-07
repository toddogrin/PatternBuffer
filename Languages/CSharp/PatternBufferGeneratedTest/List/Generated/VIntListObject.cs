
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class VIntListObject : IListTestObject, IEquatable<VIntListObject> {

        public const ushort TYPE_ID = 16;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<int> VintListValue;

        public VIntListObject() {
            this.VintListValue = default(List<int>);
        }

        public VIntListObject(
            List<int> vintListValue
        ) {
            this.VintListValue = vintListValue;
        }

        public bool Equals(VIntListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntListObject)) { return false; }
            VIntListObject that = (VIntListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VintListValue
            if (this.VintListValue == null && that.VintListValue != null) { return false; }
            if (that.VintListValue != null && this.VintListValue == null) { return false; }
            if (this.VintListValue.Count != that.VintListValue.Count) { return false; }
            List<int>.Enumerator enumerator_ipHaR1l3SLpx = this.VintListValue.GetEnumerator();
            List<int>.Enumerator enumerator_cFbahT56HxHR = that.VintListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_ipHaR1l3SLpx.MoveNext()) { break; }
                enumerator_cFbahT56HxHR.MoveNext();
            if (enumerator_ipHaR1l3SLpx.Current != enumerator_cFbahT56HxHR.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.VintListValue == null ? 0 : this.VintListValue.GetHashCode());
                return hash;
            }
        }
    }
}
