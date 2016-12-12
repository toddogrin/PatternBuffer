
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class UShortObject : IEquatable <UShortObject>, IUShortObject {
        public UShortObject() {
            this.ushortValue = default(ushort);
        }

        public UShortObject(
            ushort ushortValue
        ) {
            this.ushortValue = ushortValue;
        }

        internal ushort ushortValue;
        public ushort UshortValue {
            get { return this.ushortValue; }
            set { this.ushortValue = value; }
        }

        public bool Equals(UShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is UShortObject)) { return false; }
            UShortObject that = (UShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ushortValue
            if (this.ushortValue != that.ushortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + ushortValue.GetHashCode();
                return hash;
            }
        }
    }
}
