
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ByteObject : IPrimitiveTestObject, IEquatable<ByteObject> {

        public const ushort TYPE_ID = 21;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public byte ByteValue; // (required)

        public ByteObject() {
            this.ByteValue = default(byte);
        }

        public ByteObject(
            byte byteValue
        ) {
            this.ByteValue = byteValue;
        }

        public bool Equals(ByteObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ByteObject)) { return false; }
            ByteObject that = (ByteObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ByteValue (required)
            if (this.ByteValue != that.ByteValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.ByteValue.GetHashCode();
                return hash;
            }
        }
    }
}
