
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class BoolObject : IPrimitiveTestObject, IEquatable<BoolObject> {

        public const ushort TYPE_ID = 20;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool BoolValue;

        public BoolObject() {
            this.BoolValue = default(bool);
        }

        public BoolObject(
            bool boolValue
        ) {
            this.BoolValue = boolValue;
        }

        public bool Equals(BoolObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is BoolObject)) { return false; }
            BoolObject that = (BoolObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // BoolValue
            if (this.BoolValue != that.BoolValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.BoolValue.GetHashCode();
                return hash;
            }
        }
    }
}
