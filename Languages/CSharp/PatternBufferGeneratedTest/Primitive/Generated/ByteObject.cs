
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ByteObject : IEquatable <ByteObject>, IByteObject {
        public ByteObject() {
            this.byteValue = default(byte);
        }

        public ByteObject(
            byte byteValue
        ) {
            this.byteValue = byteValue;
        }

        internal byte byteValue;
        public byte ByteValue {
            get { return this.byteValue; }
            set { this.byteValue = value; }
        }

        public bool Equals(ByteObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ByteObject)) { return false; }
            ByteObject that = (ByteObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // byteValue
            if (this.byteValue != that.byteValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + byteValue.GetHashCode();
                return hash;
            }
        }
    }
}
