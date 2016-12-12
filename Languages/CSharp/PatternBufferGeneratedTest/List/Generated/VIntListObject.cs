
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class VIntListObject : IEquatable <VIntListObject>, IVIntListObject {
        public VIntListObject() {
            this.vintListValue = default(List<int>);
        }

        public VIntListObject(
            List<int> vintListValue
        ) {
            this.vintListValue = vintListValue;
        }

        internal List<int> vintListValue;
        public List<int> VintListValue {
            get { return this.vintListValue; }
            set { this.vintListValue = value; }
        }

        public bool Equals(VIntListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntListObject)) { return false; }
            VIntListObject that = (VIntListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vintListValue
            if (this.vintListValue == null && that.vintListValue != null) { return false; }
            if (that.vintListValue != null && this.vintListValue == null) { return false; }
            if (this.vintListValue.Count != that.vintListValue.Count) { return false; }
            List<int>.Enumerator enumerator_c09743f3e9 = this.vintListValue.GetEnumerator();
            List<int>.Enumerator enumerator_3deffbb7cd = that.vintListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_c09743f3e9.MoveNext()) { break; }
                enumerator_3deffbb7cd.MoveNext();
            if (enumerator_c09743f3e9.Current != enumerator_3deffbb7cd.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (vintListValue == null ? 0 : vintListValue.GetHashCode());
                return hash;
            }
        }
    }
}
