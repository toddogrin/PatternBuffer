
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class IntListObject : IEquatable <IntListObject>, IIntListObject {
        public IntListObject() {
            this.intListValue = default(List<int>);
        }

        public IntListObject(
            List<int> intListValue
        ) {
            this.intListValue = intListValue;
        }

        internal List<int> intListValue;
        public List<int> IntListValue {
            get { return this.intListValue; }
            set { this.intListValue = value; }
        }

        public bool Equals(IntListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntListObject)) { return false; }
            IntListObject that = (IntListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intListValue
            if (this.intListValue == null && that.intListValue != null) { return false; }
            if (that.intListValue != null && this.intListValue == null) { return false; }
            if (this.intListValue.Count != that.intListValue.Count) { return false; }
            List<int>.Enumerator enumerator_b2c5040eab = this.intListValue.GetEnumerator();
            List<int>.Enumerator enumerator_22db1cfa96 = that.intListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_b2c5040eab.MoveNext()) { break; }
                enumerator_22db1cfa96.MoveNext();
            if (enumerator_b2c5040eab.Current != enumerator_22db1cfa96.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (intListValue == null ? 0 : intListValue.GetHashCode());
                return hash;
            }
        }
    }
}
