
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class UIntObject : IPrimitiveTestObject, IEquatable<UIntObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public uint UintValue; // (required)

        public UIntObject() {
            this.UintValue = default(uint);
        }

        public UIntObject(
            uint uintValue
        ) {
            this.UintValue = uintValue;
        }

        public bool Equals(UIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is UIntObject)) { return false; }
            UIntObject that = (UIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // UintValue (required)
            if (this.UintValue != that.UintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.UintValue.GetHashCode();
                return hash;
            }
        }
    }
}
