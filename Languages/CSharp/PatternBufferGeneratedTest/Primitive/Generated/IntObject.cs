
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class IntObject : IPrimitiveTestObject, IEquatable<IntObject> {

        public const ushort TYPE_ID = 779;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int IntValue;

        public IntObject() {
            this.IntValue = default(int);
        }

        public IntObject(
            int intValue
        ) {
            this.IntValue = intValue;
        }

        public bool Equals(IntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntObject)) { return false; }
            IntObject that = (IntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntValue
            if (this.IntValue != that.IntValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IntValue.GetHashCode();
                return hash;
            }
        }
    }
}
