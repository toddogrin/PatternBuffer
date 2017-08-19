
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ShortObject : IPrimitiveTestObject, IEquatable<ShortObject> {

        public const ushort TYPE_ID = 11;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public short ShortValue; // (required)

        public ShortObject() {
            this.ShortValue = default(short);
        }

        public ShortObject(
            short shortValue
        ) {
            this.ShortValue = shortValue;
        }

        public bool Equals(ShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ShortObject)) { return false; }
            ShortObject that = (ShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ShortValue (required)
            if (this.ShortValue != that.ShortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.ShortValue.GetHashCode();
                return hash;
            }
        }
    }
}
