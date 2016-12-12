
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class DoubleObject : IEquatable <DoubleObject>, IDoubleObject {
        public DoubleObject() {
            this.doubleValue = default(double);
        }

        public DoubleObject(
            double doubleValue
        ) {
            this.doubleValue = doubleValue;
        }

        internal double doubleValue;
        public double DoubleValue {
            get { return this.doubleValue; }
            set { this.doubleValue = value; }
        }

        public bool Equals(DoubleObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is DoubleObject)) { return false; }
            DoubleObject that = (DoubleObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // doubleValue
            if (this.doubleValue != that.doubleValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + doubleValue.GetHashCode();
                return hash;
            }
        }
    }
}
