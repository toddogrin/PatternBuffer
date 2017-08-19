
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VLongObject : IPrimitiveTestObject, IEquatable<VLongObject> {

        public const ushort TYPE_ID = 113;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public long VlongValue; // (required)

        public VLongObject() {
            this.VlongValue = default(long);
        }

        public VLongObject(
            long vlongValue
        ) {
            this.VlongValue = vlongValue;
        }

        public bool Equals(VLongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is VLongObject)) { return false; }
            VLongObject that = (VLongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VlongValue (required)
            if (this.VlongValue != that.VlongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.VlongValue.GetHashCode();
                return hash;
            }
        }
    }
}
