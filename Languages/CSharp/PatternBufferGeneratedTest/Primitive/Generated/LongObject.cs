
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class LongObject : IPrimitiveTestObject, IEquatable<LongObject> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public long LongValue; // (required)

        public LongObject() {
            this.LongValue = default(long);
        }

        public LongObject(
            long longValue
        ) {
            this.LongValue = longValue;
        }

        public bool Equals(LongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is LongObject)) { return false; }
            LongObject that = (LongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // LongValue (required)
            if (this.LongValue != that.LongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.LongValue.GetHashCode();
                return hash;
            }
        }
    }
}
