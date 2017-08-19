
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VULongObject : IPrimitiveTestObject, IEquatable<VULongObject> {

        public const ushort TYPE_ID = 116;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public ulong VulongValue;

        public VULongObject() {
            this.VulongValue = default(ulong);
        }

        public VULongObject(
            ulong vulongValue
        ) {
            this.VulongValue = vulongValue;
        }

        public bool Equals(VULongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VULongObject)) { return false; }
            VULongObject that = (VULongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VulongValue
            if (this.VulongValue != that.VulongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.VulongValue.GetHashCode();
                return hash;
            }
        }
    }
}
