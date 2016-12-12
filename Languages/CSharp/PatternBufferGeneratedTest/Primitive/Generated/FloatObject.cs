
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class FloatObject : IEquatable <FloatObject>, IFloatObject {
        public FloatObject() {
            this.floatValue = default(float);
        }

        public FloatObject(
            float floatValue
        ) {
            this.floatValue = floatValue;
        }

        internal float floatValue;
        public float FloatValue {
            get { return this.floatValue; }
            set { this.floatValue = value; }
        }

        public bool Equals(FloatObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FloatObject)) { return false; }
            FloatObject that = (FloatObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // floatValue
            if (this.floatValue != that.floatValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + floatValue.GetHashCode();
                return hash;
            }
        }
    }
}
