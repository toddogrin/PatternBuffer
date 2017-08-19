
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class DerivedType2 : BaseType, INullableTestObject, IEquatable<DerivedType2> {

        public new const ushort TYPE_ID = 11;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public byte ByteValue; // (required)

        public DerivedType2() {
            this.BooleanValue = default(bool);
            this.ByteValue = default(byte);
        }

        public DerivedType2(
            bool booleanValue,
            byte byteValue
        ) {
            this.BooleanValue = booleanValue;
            this.ByteValue = byteValue;
        }

        public bool Equals(DerivedType2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is DerivedType2)) { return false; }
            DerivedType2 that = (DerivedType2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ByteValue (required)
            if (this.ByteValue != that.ByteValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.BooleanValue.GetHashCode();
                hash = (13*hash) + this.ByteValue.GetHashCode();
                return hash;
            }
        }
    }
}
