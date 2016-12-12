
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class UIntObject : IEquatable <UIntObject>, IUIntObject {
        public UIntObject() {
            this.uintValue = default(uint);
        }

        public UIntObject(
            uint uintValue
        ) {
            this.uintValue = uintValue;
        }

        internal uint uintValue;
        public uint UintValue {
            get { return this.uintValue; }
            set { this.uintValue = value; }
        }

        public bool Equals(UIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is UIntObject)) { return false; }
            UIntObject that = (UIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // uintValue
            if (this.uintValue != that.uintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + uintValue.GetHashCode();
                return hash;
            }
        }
    }
}
