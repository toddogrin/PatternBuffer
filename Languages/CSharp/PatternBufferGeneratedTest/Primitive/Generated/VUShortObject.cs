
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VUShortObject : IEquatable <VUShortObject>, IVUShortObject {
        public VUShortObject() {
            this.vushortValue = default(ushort);
        }

        public VUShortObject(
            ushort vushortValue
        ) {
            this.vushortValue = vushortValue;
        }

        internal ushort vushortValue;
        public ushort VushortValue {
            get { return this.vushortValue; }
            set { this.vushortValue = value; }
        }

        public bool Equals(VUShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VUShortObject)) { return false; }
            VUShortObject that = (VUShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vushortValue
            if (this.vushortValue != that.vushortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + vushortValue.GetHashCode();
                return hash;
            }
        }
    }
}
