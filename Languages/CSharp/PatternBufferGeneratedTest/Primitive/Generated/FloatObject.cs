
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class FloatObject : IPrimitiveTestObject, IEquatable<FloatObject> {

        public const ushort TYPE_ID = 19;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public float FloatValue; // (required)

        public FloatObject() {
            this.FloatValue = default(float);
        }

        public FloatObject(
            float floatValue
        ) {
            this.FloatValue = floatValue;
        }

        public bool Equals(FloatObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is FloatObject)) { return false; }
            FloatObject that = (FloatObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // FloatValue (required)
            if (this.FloatValue != that.FloatValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.FloatValue.GetHashCode();
                return hash;
            }
        }
    }
}
