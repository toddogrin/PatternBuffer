
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class DoubleObject : IPrimitiveTestObject, IEquatable<DoubleObject> {

        public const ushort TYPE_ID = 18;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public double DoubleValue; // (required)

        public DoubleObject() {
            this.DoubleValue = default(double);
        }

        public DoubleObject(
            double doubleValue
        ) {
            this.DoubleValue = doubleValue;
        }

        public bool Equals(DoubleObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is DoubleObject)) { return false; }
            DoubleObject that = (DoubleObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // DoubleValue (required)
            if (this.DoubleValue != that.DoubleValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.DoubleValue.GetHashCode();
                return hash;
            }
        }
    }
}
