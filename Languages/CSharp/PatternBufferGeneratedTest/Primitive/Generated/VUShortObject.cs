
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VUShortObject : IPrimitiveTestObject, IEquatable<VUShortObject> {

        public const ushort TYPE_ID = 114;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public ushort VushortValue;

        public VUShortObject() {
            this.VushortValue = default(ushort);
        }

        public VUShortObject(
            ushort vushortValue
        ) {
            this.VushortValue = vushortValue;
        }

        public bool Equals(VUShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VUShortObject)) { return false; }
            VUShortObject that = (VUShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VushortValue
            if (this.VushortValue != that.VushortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.VushortValue.GetHashCode();
                return hash;
            }
        }
    }
}
