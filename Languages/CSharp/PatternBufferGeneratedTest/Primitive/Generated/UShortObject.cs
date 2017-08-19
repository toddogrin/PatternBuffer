
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class UShortObject : IPrimitiveTestObject, IEquatable<UShortObject> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public ushort UshortValue; // (required)

        public UShortObject() {
            this.UshortValue = default(ushort);
        }

        public UShortObject(
            ushort ushortValue
        ) {
            this.UshortValue = ushortValue;
        }

        public bool Equals(UShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is UShortObject)) { return false; }
            UShortObject that = (UShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // UshortValue (required)
            if (this.UshortValue != that.UshortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.UshortValue.GetHashCode();
                return hash;
            }
        }
    }
}
