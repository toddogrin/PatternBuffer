
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class BoolObject : IEquatable <BoolObject>, IBoolObject {
        public BoolObject() {
            this.boolValue = default(bool);
        }

        public BoolObject(
            bool boolValue
        ) {
            this.boolValue = boolValue;
        }

        internal bool boolValue;
        public bool BoolValue {
            get { return this.boolValue; }
            set { this.boolValue = value; }
        }

        public bool Equals(BoolObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is BoolObject)) { return false; }
            BoolObject that = (BoolObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // boolValue
            if (this.boolValue != that.boolValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + boolValue.GetHashCode();
                return hash;
            }
        }
    }
}
