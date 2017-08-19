
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VUIntObject : IPrimitiveTestObject, IEquatable<VUIntObject> {

        public const ushort TYPE_ID = 115;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public uint VuintValue; // (required)

        public VUIntObject() {
            this.VuintValue = default(uint);
        }

        public VUIntObject(
            uint vuintValue
        ) {
            this.VuintValue = vuintValue;
        }

        public bool Equals(VUIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is VUIntObject)) { return false; }
            VUIntObject that = (VUIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VuintValue (required)
            if (this.VuintValue != that.VuintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.VuintValue.GetHashCode();
                return hash;
            }
        }
    }
}
