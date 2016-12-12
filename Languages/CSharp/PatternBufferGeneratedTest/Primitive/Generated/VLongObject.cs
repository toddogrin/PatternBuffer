
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VLongObject : IEquatable <VLongObject>, IVLongObject {
        public VLongObject() {
            this.vlongValue = default(long);
        }

        public VLongObject(
            long vlongValue
        ) {
            this.vlongValue = vlongValue;
        }

        internal long vlongValue;
        public long VlongValue {
            get { return this.vlongValue; }
            set { this.vlongValue = value; }
        }

        public bool Equals(VLongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VLongObject)) { return false; }
            VLongObject that = (VLongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vlongValue
            if (this.vlongValue != that.vlongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + vlongValue.GetHashCode();
                return hash;
            }
        }
    }
}
