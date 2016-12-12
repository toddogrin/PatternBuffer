
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VULongObject : IEquatable <VULongObject>, IVULongObject {
        public VULongObject() {
            this.vulongValue = default(ulong);
        }

        public VULongObject(
            ulong vulongValue
        ) {
            this.vulongValue = vulongValue;
        }

        internal ulong vulongValue;
        public ulong VulongValue {
            get { return this.vulongValue; }
            set { this.vulongValue = value; }
        }

        public bool Equals(VULongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VULongObject)) { return false; }
            VULongObject that = (VULongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vulongValue
            if (this.vulongValue != that.vulongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + vulongValue.GetHashCode();
                return hash;
            }
        }
    }
}
