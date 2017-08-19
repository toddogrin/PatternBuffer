
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ULongObject : IPrimitiveTestObject, IEquatable<ULongObject> {

        public const ushort TYPE_ID = 16;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public ulong UlongValue; // (required)

        public ULongObject() {
            this.UlongValue = default(ulong);
        }

        public ULongObject(
            ulong ulongValue
        ) {
            this.UlongValue = ulongValue;
        }

        public bool Equals(ULongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ULongObject)) { return false; }
            ULongObject that = (ULongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // UlongValue (required)
            if (this.UlongValue != that.UlongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.UlongValue.GetHashCode();
                return hash;
            }
        }
    }
}
